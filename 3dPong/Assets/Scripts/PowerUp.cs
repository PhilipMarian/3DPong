using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {
    GameObject Ball;

	void Start () {
        Ball = GameObject.Find("Ball");

	}
	
	void Update () {
	
	}

    void onCollisionEnter(Collision c)
    {
        if (c.collider.tag == "Ball")
        {
            Ball.GetComponent<PongMover>().speed;
            Destroy(gameObject);
        }

    }

}
