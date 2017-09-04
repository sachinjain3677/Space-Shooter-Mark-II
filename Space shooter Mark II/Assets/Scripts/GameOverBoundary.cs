using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverBoundary : MonoBehaviour {

    private GameController obj;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Asteroid")) {
            obj.GameOver();
        }
    }


}
