using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth1 : MonoBehaviour {

	public int startingHealth = 30;
	public int currentHealth;
	public Slider healthSlider;
	public GameObject explosion;
	public GameObject explosionSmall;

	private GameController gameController;


	//bool isDestroyed;
	//bool isDamaged;


	void Awake(){
		
		currentHealth = startingHealth;
	}

	void Start(){
		GameObject gameControllerObject = GameObject.FindWithTag("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent<GameController>();
		}
		if (gameController == null)
		{
			Debug.Log("Cannot find 'GameController' script");
		}
	}

	public void TakeDamage(int amount){
		//isDamaged = true;
		currentHealth -= amount;
		healthSlider.value = currentHealth;
		Instantiate(explosionSmall, transform.position, transform.rotation);

		if (currentHealth <= 0) {
			Death ();	
		}
	}

	void Death(){
		Instantiate(explosion, transform.position, transform.rotation);
		Destroy(gameObject);
		gameController.GameOver();

	}


}
