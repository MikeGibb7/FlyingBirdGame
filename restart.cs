using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour
{
    // Start is called before the first frame update
    int score = 0;
    int highScore;
    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
        highScore = PlayerPrefs.GetInt("HighScore");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
            }
        }
    }
    void OnGUI()
    {
        GUI.Box(new Rect(450, 100, 150, 30), ("Score: " + score.ToString()));
        GUI.Box(new Rect(450, 50, 150, 30), ("HighScore: " + highScore.ToString()));
    }
}
