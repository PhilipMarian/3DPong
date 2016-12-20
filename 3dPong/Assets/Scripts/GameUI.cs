using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour {

    GameObject Pong;
    GameObject Player;
    GameObject PowerUp;


    public GUIStyle style;

    string helloWorld;
    string score;
    string debuffTimer;
    string buffTimer;

    int wins;
    int loses;
    float debuffTime;
    float buffTime;

    void Start () {
        Pong = GameObject.Find("Pong");
        Player = GameObject.Find("PlayerOne");
        PowerUp = GameObject.Find("PowerUp");

        helloWorld = "Hello World!\nDon't let the ball touch the wall behind you!";
        //debufftimer bufftimer;

    }
    void Update () {
        score = "Score: " + wins + " / " + loses;
        debuffTimer = "Debuffs: ";
        buffTimer = "Buff: ";
    }
    void OnGUI()
    {
        //GUI.Label(new Rect(xpos, ypos, width, height), string, style);
        GUI.Label(new Rect(10, 10, 100, 150), helloWorld, style);
        GUI.Label(new Rect(250, 10, 100, 150), score);
        GUI.Label(new Rect(500, 10, 100, 150), debuffTimer);
        GUI.Label(new Rect(500, 25, 100, 150), buffTimer);

        if (GUI.Button(new Rect(400, 250, 200, 30), "Restart Level"))
        {
            SceneManager.LoadScene("Game");
        }
        if (GUI.Button(new Rect(400, 300, 200, 30), "Exit"))
        {
            SceneManager.LoadScene("Exit");
        }
    }
}
