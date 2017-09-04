using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    public GameObject explosion;
    public GameObject playerExplosion;
    public int scoreValue;
    private GameControllerSingle gameController;

    void Start() {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null) {
            gameController = gameControllerObject.GetComponent<GameControllerSingle>();
        }
        if (gameController == null) {
            Debug.Log("Cannot find 'GameController' script");
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "BoundarySingle") {
            return;
        }
        
        if (other.tag == "Player")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            gameController.GameOver();
            scoreValue = 0;
        }

        if (other.tag == "Edge") {
            gameController.GameOver();
            scoreValue = 0;
        }

        if (other.tag == "Bolt") {
            Instantiate(explosion, transform.position, transform.rotation);
        }

        gameController.AddScore(scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
