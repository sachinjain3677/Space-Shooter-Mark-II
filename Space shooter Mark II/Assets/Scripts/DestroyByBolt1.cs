using UnityEngine;

public class DestroyByBolt1 : MonoBehaviour
{

	public GameObject explosion;


	PlayerHealth1 player1;

	void Start()
	{
		GameObject player1Object = GameObject.FindWithTag("Player1");
		if (player1Object != null)
		{
			player1 = player1Object.GetComponent<PlayerHealth1>();
		}
		if (player1 == null)
		{
			Debug.Log("Cannot find 'PlayerHealth1' script");
		}



	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Boundary")
		{
			Destroy(gameObject);
		}


		if (other.tag == "Player1")
		{
			player1.TakeDamage (10);

			Destroy(gameObject);


		}








		if (other.tag == "Player1Shot")
		{
			Instantiate(explosion, transform.position, transform.rotation);
			Destroy (gameObject);
		}



	}
}
