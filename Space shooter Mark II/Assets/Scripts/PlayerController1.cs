using UnityEngine;
using System.Collections;

[System.Serializable]
public class BoundarySingle
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController1 : MonoBehaviour
{


    public float speed;
    public BoundarySingle boundary;
    public float tilt;
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;



    private Rigidbody rb2;
    private float nextFire;
    private AudioSource a;

    void Start()
    {
        rb2 = GetComponent<Rigidbody>();
        a = GetComponent<AudioSource>();
        
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            a.Play();
        }



    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveVertical, 0.0f, -moveHorizontal);
        rb2.velocity = movement * speed;
        rb2.position = new Vector3
            (
            Mathf.Clamp(rb2.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(rb2.position.z, boundary.zMin, boundary.zMax)
            );
        rb2.rotation = Quaternion.Euler(0.0f, 0.0f, rb2.velocity.x * -tilt);
    }
}
