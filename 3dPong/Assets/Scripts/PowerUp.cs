using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {
    GameObject Ball;
    GameObject PowerUpPrefab;
    float debufftimer;
    float bufftimer;
   
    public Transform SpawnPointOne;
    public Transform SpawnPointTwo;
    public Transform SpawnPointThree;
    public Transform SpawnPointFour;
    public Transform SpawnPointFive;

    int spawnPoint;
    float lifeTime;
    float respawnTime;

    void Start () {
        Ball = GameObject.Find("Ball");
        PowerUpPrefab = GameObject.Find("PowerUp");
        spawnPoint = Random.Range(0, 4);
        respawnTime = Random.Range(10, 15);

    }
	
	void Update () {
        if (Input.GetKeyDown("c"))
        {
            Instantiate(PowerUpPrefab, SpawnPointOne.position, SpawnPointOne.rotation);
            Instantiate(PowerUpPrefab, SpawnPointTwo.position, SpawnPointTwo.rotation);
            Instantiate(PowerUpPrefab, SpawnPointThree.position, SpawnPointTwo.rotation);
            Instantiate(PowerUpPrefab, SpawnPointFour.position, SpawnPointTwo.rotation);
            Instantiate(PowerUpPrefab, SpawnPointFive.position, SpawnPointTwo.rotation);
        }
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
        if (respawnTime<0)
        {

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
