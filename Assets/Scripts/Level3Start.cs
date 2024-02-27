using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3Start : MonoBehaviour
{
    float time = 0;
    public static string minutes;
    public static string seconds;
    public static string mSeconds;
    float temp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        minutes = Mathf.Floor(time / 60).ToString("00");
        seconds = (time % 60).ToString("00");
        temp = time * 1000;
        mSeconds = (temp % 1000).ToString("000");
    }

    public void level3start()
    {
        SceneManager.LoadScene("Level3");
    }
}
