using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTextChange : MonoBehaviour
{
    public static string randomFruitName;
    [SerializeField] GameObject fruitNameText;
    [SerializeField] GameObject countText;
    float timeCount = 12;
    int fruitNumber;

    bool appleAnimation = false;
    bool bananaAnimation = false;
    bool plumAnimation = false;
    bool orangeAnimation = false;
    bool grapeAnimation = false;

    [SerializeField] GameObject fruitChangeAnimation;

    public static bool level2Played = false;

    // Start is called before the first frame update
    void Start()
    {
        level2Played = true;
        fruitNumber = Random.Range(1, 6);

    
    }

    // Update is called once per frame
    void Update()
    {
        timeCount -= Time.deltaTime;
        if (timeCount < 0)
        {
            timeCount = 12;
            fruitNumber = Random.Range(1, 5);
        }
        
     
        if (fruitNumber==1)
        {
            if (appleAnimation == false)
            {
                Instantiate(fruitChangeAnimation, new Vector3(0f, 0.2f, -0.7f), Quaternion.identity);
                appleAnimation = true;

                bananaAnimation = false;
                plumAnimation = false;
                orangeAnimation = false;
                grapeAnimation = false;
            }
            randomFruitName = "Apple";
            countText.GetComponent<UnityEngine.UI.Text>().text = Fruits.appleCount.ToString();
            fruitNameText.GetComponent<UnityEngine.UI.Text>().text = "Apple";
        }
        else if (fruitNumber == 2)
        {
            if (bananaAnimation == false)
            {
                Instantiate(fruitChangeAnimation, new Vector3(0f, 0.2f, -0.7f), Quaternion.identity);
                bananaAnimation = true;

                appleAnimation = false;
                plumAnimation = false;
                orangeAnimation = false;
                grapeAnimation = false;
            }
            randomFruitName = "Banana";
            countText.GetComponent<UnityEngine.UI.Text>().text = Fruits.bananaCount.ToString();
            fruitNameText.GetComponent<UnityEngine.UI.Text>().text = "Banana";
        }
        else if (fruitNumber == 3)
        {
            if (plumAnimation == false)
            {
                Instantiate(fruitChangeAnimation, new Vector3(0f, 0.2f, -0.7f), Quaternion.identity);
                plumAnimation = true;

                appleAnimation = false;
                bananaAnimation = false;
                orangeAnimation = false;
                grapeAnimation = false;
            }
            randomFruitName = "Plum";
            countText.GetComponent<UnityEngine.UI.Text>().text = Fruits.plumCount.ToString();
            fruitNameText.GetComponent<UnityEngine.UI.Text>().text = "Plum";
        }
        else if (fruitNumber == 4)
        {
            if (orangeAnimation == false)
            {
                Instantiate(fruitChangeAnimation, new Vector3(0f, 0.2f, -0.7f), Quaternion.identity);
                orangeAnimation = true;

                appleAnimation = false;
                bananaAnimation = false;
                plumAnimation = false;
                grapeAnimation = false;
            }
            randomFruitName = "Orange";
            countText.GetComponent<UnityEngine.UI.Text>().text = Fruits.orangeCount.ToString();
            fruitNameText.GetComponent<UnityEngine.UI.Text>().text = "Orange";
        }
        else if (fruitNumber == 5)
        {
            if (grapeAnimation == false)
            {
                Instantiate(fruitChangeAnimation, new Vector3(0f, 0.2f, -0.7f), Quaternion.identity);
                grapeAnimation = true;

                appleAnimation = false;
                bananaAnimation = false;
                plumAnimation = false;
                orangeAnimation = false;
            }
            randomFruitName = "Grape";
            countText.GetComponent<UnityEngine.UI.Text>().text = Fruits.grapeCount.ToString();
            fruitNameText.GetComponent<UnityEngine.UI.Text>().text = "Grape";
        }

        

    }
}
