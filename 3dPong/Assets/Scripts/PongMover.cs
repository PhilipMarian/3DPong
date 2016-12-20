using UnityEngine;
using System.Collections;

public class PongMover : MonoBehaviour {

    public Vector3 initialForce;
    public Rigidbody rb;

    public float speed;
    

    void Start () {
        rb = GetComponent<Rigidbody>();
    }

	void Update () {
        rb.velocity = initialForce;
        rb.AddForce(initialForce, ForceMode.Impulse);
    }

    void onCollisionEnter(Collision c)
    {
        if(c.collider.tag == "Player")
        {
          // initialForce.z = -initialForce.z;
          //  rb.AddForce(10, 0, 10);
        }
        if (c.collider.tag == "Walls")
        {
          // initialForce.z = -initialForce.z;
          //  rb.AddForce(5, 0, 0);
        }
    }
}
