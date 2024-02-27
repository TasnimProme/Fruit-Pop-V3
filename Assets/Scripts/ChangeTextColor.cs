using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextColor : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject instruction;
    [SerializeField] GameObject startButton;
    float time = 0;
    int seconds = 0;

    void Start()
    {
        //startButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if((time % 60)==0)
        {
            seconds++;
        }

        if(time >= 1 && time < 1.5)
            instruction.GetComponent<UnityEngine.UI.Text>().text = "<color=#ff0000ff>For</color> this round you need to pop only apples \nPop the different looking fruits to get extra points";
        if (time >= 1.5 && time < 2)
            instruction.GetComponent<UnityEngine.UI.Text>().text = "<color=#ff0000ff>For this</color> round you need to pop only apples \nPop the different looking fruits to get extra points";
        if (time >= 2 && time < 2.5)
            instruction.GetComponent<UnityEngine.UI.Text>().text = "<color=#ff0000ff>For this round</color> you need to pop only apples \nPop the different looking fruits to get extra points";
        if (time >= 2.5 && time < 3)
            instruction.GetComponent<UnityEngine.UI.Text>().text = "<color=#ff0000ff>For this round you</color> need to pop only apples \nPop the different looking fruits to get extra points";
        if (time >= 3 && time < 3.5)
            instruction.GetComponent<UnityEngine.UI.Text>().text = "<color=#ff0000ff>For this round you need</color> to pop only apples \nPop the different looking fruits to get extra points";
        if (time >= 3.5 && time < 4)
            instruction.GetComponent<UnityEngine.UI.Text>().text = "<color=#ff0000ff>For this round you need to</color> pop only apples \nPop the different looking fruits to get extra points";
        if (time >= 4 && time < 4.5)
            instruction.GetComponent<UnityEngine.UI.Text>().text = "<color=#ff0000ff>For this round you need to pop</color> only apples \nPop the different looking fruits to get extra points";
        if (time >= 4.5 && time < 5)
            instruction.GetComponent<UnityEngine.UI.Text>().text = "<color=#ff0000ff>For this round you need to pop only</color> apples \nPop the different looking fruits to get extra points";
        if (time >= 5 && time < 5.5)
            instruction.GetComponent<UnityEngine.UI.Text>().text = "<color=#ff0000ff>For this round you need to pop only apples</color> \nPop the different looking fruits to get extra points";
        if (time >= 6 && time < 6.5)
            instruction.GetComponent<UnityEngine.UI.Text>().text = "<color=#ff0000ff>For this round you need to pop only apples \nPop</color> the different looking fruits to get extra points";
        if (time >= 6.5 && time < 7)
            instruction.GetComponent<UnityEngine.UI.Text>().text = "<color=#ff0000ff>For this round you need to pop only apples \nPop the</color> different looking fruits to get extra points";
        if (time >= 7 && time < 7.5)
            instruction.GetComponent<UnityEngine.UI.Text>().text = "<color=#ff0000ff>For this round you need to pop only apples \nPop the different</color> looking fruits to get extra points";
        if (time >= 7.5 && time < 8)
            instruction.GetComponent<UnityEngine.UI.Text>().text = "<color=#ff0000ff>For this round you need to pop only apples \nPop the different looking</color> fruits to get extra points";
        if (time >= 8 && time < 8.5)
            instruction.GetComponent<UnityEngine.UI.Text>().text = "<color=#ff0000ff>For this round you need to pop only apples \nPop the different looking fruits</color> to get extra points";
        if (time >= 8.5 && time < 9)
            instruction.GetComponent<UnityEngine.UI.Text>().text = "<color=#ff0000ff>For this round you need to pop only apples \nPop the different looking fruits to</color> get extra points";
        if (time >= 9 && time < 9.5)
            instruction.GetComponent<UnityEngine.UI.Text>().text = "<color=#ff0000ff>For this round you need to pop only apples \nPop the different looking fruits to get</color> extra points";
        if (time >= 9.5 && time < 10)
            instruction.GetComponent<UnityEngine.UI.Text>().text = "<color=#ff0000ff>For this round you need to pop only apples \nPop the different looking fruits to get extra</color> points";
        if (time >= 10 && time < 10.5)
            instruction.GetComponent<UnityEngine.UI.Text>().text = "<color=#ff0000ff>For this round you need to pop only apples \nPop the different looking fruits to get extra points</color>";
        if (time >= 11)
            startButton.SetActive(true);
    }
}
