using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public static string fruitName;
    [SerializeField] GameObject fruitNameText;
    [SerializeField] GameObject countText;
    float time = 120;

    bool bananaAnimation = false;
    bool plumAnimation = false;
    bool orangeAnimation = false;
    bool grapeAnimation = false;


    [SerializeField] GameObject fruitChangeAnimation;

    // Start is called before the first frame update
    void Start()
    {
        // fruitName = "Apple";
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        string minutes = Mathf.Floor(time / 60).ToString("00");
        string seconds = (time % 60).ToString("00");
        // timerText.text = "Time Left: " + minutes + ":" + seconds;
        if (time>=96 && time <= 120)
        {
            //if (time == 100)
            
            fruitName = "Apple";
            countText.GetComponent<UnityEngine.UI.Text>().text = Fruits.appleCount.ToString();
            fruitNameText.GetComponent<UnityEngine.UI.Text>().text = "Apple";
        }
        else if(time >= 72 && time < 96)
        {
            if (bananaAnimation == false)
            {
                Instantiate(fruitChangeAnimation, new Vector3(0f, 0.2f, -0.7f), Quaternion.identity);
                bananaAnimation = true;
            }

            fruitName = "Banana";
            countText.GetComponent<UnityEngine.UI.Text>().text = Fruits.bananaCount.ToString();
            fruitNameText.GetComponent<UnityEngine.UI.Text>().text = "Banana";
        }
        else if (time >= 48 && time < 72)
        {
            if (plumAnimation == false)
            {
                Instantiate(fruitChangeAnimation, new Vector3(0f, 0.2f, -0.7f), Quaternion.identity);
                plumAnimation = true;
            }
            fruitName = "Plum";
            countText.GetComponent<UnityEngine.UI.Text>().text = Fruits.plumCount.ToString();
            fruitNameText.GetComponent<UnityEngine.UI.Text>().text = "Plum";
        }
        else if (time >= 24 && time < 48)
        {
            if (orangeAnimation == false)
            {
                Instantiate(fruitChangeAnimation, new Vector3(0f, 0.2f, -0.7f), Quaternion.identity);
                orangeAnimation = true;
            }
            fruitName = "Orange";
            countText.GetComponent<UnityEngine.UI.Text>().text = Fruits.orangeCount.ToString();
            fruitNameText.GetComponent<UnityEngine.UI.Text>().text = "Orange";
        }
        else
        {
            if (grapeAnimation == false)
            {
                Instantiate(fruitChangeAnimation, new Vector3(0f, 0.2f, -0.7f), Quaternion.identity);
                grapeAnimation = true;
            }
            fruitName = "Grape";
            countText.GetComponent<UnityEngine.UI.Text>().text = Fruits.grapeCount.ToString();
            fruitNameText.GetComponent<UnityEngine.UI.Text>().text = "Grape";
        }
    }
}
