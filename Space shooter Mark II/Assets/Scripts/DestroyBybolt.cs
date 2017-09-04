using UnityEngine;

public class DestroyBybolt : MonoBehaviour
{

    public GameObject explosion;
    

	PlayerHealth2 player2;

    void Start()
    {
		GameObject player2Object = GameObject.FindWithTag("Player2");
		if (player2Object != null)
		{
			player2 = player2Object.GetComponent<PlayerHealth2>();
		}
		if (player2 == null)
		{
			Debug.Log("Cannot find 'PlayerHealth2' script");
		}




    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            Destroy(gameObject);
        }

        
            if (other.tag == "Player2")
            {
			player2.TakeDamage (10);
                
                Destroy(gameObject);
                

            }
        
        






        if (other.tag == "Player2Shot")
        {
            Instantiate(explosion, transform.position, transform.rotation);
			Destroy (gameObject);
        }



    }
}
