using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour {
    public string firstScene;
    public string secondScene;

    public string buttonOne;
    public string buttonTwo;
	void OnGUI () {
        if (GUI.Button(new Rect(200, 150, 200, 30), buttonOne))
        {
            SceneManager.LoadScene(firstScene);
        }
        if (GUI.Button(new Rect(200, 200, 200, 30), buttonTwo))
        {
            SceneManager.LoadScene(secondScene);
        }
    }

}
