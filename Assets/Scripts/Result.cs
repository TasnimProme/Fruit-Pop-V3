using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    [SerializeField] GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.GetComponent<UnityEngine.UI.Text>().text = "You have collected\n " + Fruits.appleCount + " out of " + Fruits.totalAppleCount + " Apples\n" +
            Fruits.bananaCount + " out of " + Fruits.totalBananaCount + " Bananas\n" + Fruits.plumCount + " out of " + Fruits.totalPlumCount + " Plums\n" +
            Fruits.orangeCount + " out of " + Fruits.totalOrangeCount + " Oranges\n" + Fruits.grapeCount + " out of " + Fruits.totalGrapeCount + " Grapes";


    }

    public void Next()
    {
        if(RandomTextChange.level2Played)
            SceneManager.LoadScene("Start3");
        else
            SceneManager.LoadScene("Start2");

        // Application.Quit();
    }
}
