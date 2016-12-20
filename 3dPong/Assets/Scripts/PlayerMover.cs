using UnityEngine;
using System.Collections;

public class PlayerMover : MonoBehaviour {
    int health;
    int wins;
    int loses;
    float Speed;

    void Start () {
	
	}

	void Update () {
        Speed = 0.2f;
        transform.Translate(0, Input.GetAxis("Horizontal") * Speed, 0);
        //Speed = Input.GetAxisRaw("Horizontal");
        //transform.position += new Vector3(0.0f, 0.0f, Speed * Time.deltaTime);
    }
}
