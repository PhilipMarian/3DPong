using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {
    GameObject Ball;
    float debufftimer;
    float bufftimer;

    Transform SpawnPointOne;
    Transform SpawnPointTwo;
    Transform SpawnPointThree;
    Transform SpawnPointFour;
    Transform SpawnPointFive;
    
    void Start () {
        Ball = GameObject.Find("Ball");
	}
	
	void Update () {
        if (Input.GetKey("z"))
        {
            Debug.Log(debufftimer);
            debufftimer -= Time.deltaTime;
            if (debufftimer < 0)
            {
                debufftimer = 5.0f;
            }
        }
        if (Input.GetKey("c"))
        {
            Debug.Log(bufftimer);
            bufftimer -= Time.deltaTime;
            if (bufftimer < 0)
            {
                bufftimer = 5.0f;
            }
        }
    }

    void onCollisionEnter(Collision c)
    {
        if (c.collider.tag == "Ball")
        {
            //Ball.GetComponent<PongMover>().speed;
            Destroy(gameObject);
        }
    }
}
