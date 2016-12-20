using UnityEngine;
using System.Collections;

public class PongMover : MonoBehaviour {
    float ax;
    float ay;
    float az;

    public Vector3 initialForce;
    public Rigidbody rb;
    public GameObject PowerUp;

    public float speed;
    

    void Start () {
        rb = GetComponent<Rigidbody>();

        ax = Random.Range(0, 2) == 0 ? -1 : 1;
        ay = Random.Range(0, 2) == 0 ? -1 : 1;
        az = Random.Range(0, 2) == 0 ? -1 : 1;

        rb.velocity = new Vector3(Random.Range(5, 10) * ax, Random.Range(5, 10) * ay, Random.Range(5, 10) * az);

        PowerUp = GameObject.Find("PowerUp");

    }

	void Update () {
    //rb.velocity = initialForce;
    //rb.AddForce(initialForce, ForceMode.Impulse);

    }

    void onCollisionEnter(Collision c)
    {
        if(c.collider.tag == "Player")
        {
          //initialForce.z = -initialForce.z;
          //rb.AddForce(10, 0, 10);
        }
        if (c.collider.tag == "Walls")
        {
            rb.velocity = new Vector3(Random.Range(9, 10) * ax, Random.Range(9, 10) * ay, Random.Range(9, 10) * az);
        }
        if(c.collider.tag == "PowerUp")
        {
            Destroy(this.gameObject);
        }
    }
}
