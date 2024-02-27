using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultLevel3 : MonoBehaviour
{

    [SerializeField] GameObject text;
    [SerializeField] GameObject timeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.GetComponent<UnityEngine.UI.Text>().text = "You have collected\n " + FruitsLevel3.appleCount + " out of " + FruitsLevel3.totalApple + " Apples\n"+
            FruitsLevel3.otherFruitCount + " out of " + FruitsLevel3.totalOtherFruit + " Other Fruits";
        timeText.GetComponent<UnityEngine.UI.Text>().text = Level3Start.minutes + ":" + Level3Start.seconds + ":" + Level3Start.mSeconds;
    }

    public void Finish()
    {
         Application.Quit();
    }
}
