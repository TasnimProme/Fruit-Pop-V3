using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level3Timer : MonoBehaviour
{
    float time = 120;

    // public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        string minutes = Mathf.Floor(time / 60).ToString("00");
        string seconds = (time % 60).ToString("00");

        // timerText.text = "Time Left: " + minutes + ":" + seconds;
        if (minutes.Equals("00") && seconds.Equals("00"))
        {
            SceneManager.LoadScene("ResultLevel3");
        }
    }
}
