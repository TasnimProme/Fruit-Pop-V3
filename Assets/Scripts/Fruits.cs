using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruits : MonoBehaviour
{
    [SerializeField] GameObject[] fruits;
    [SerializeField] float secondsToSpawn;
    [SerializeField] float min;
    [SerializeField] float max;
    [SerializeField] GameObject text;
    [SerializeField] GameObject pop;

    [SerializeField] AudioSource audio;
    [SerializeField] AudioSource audioWrongFruit;

    public Camera mainCamera;

    public static int appleCount=0;
    public static int bananaCount=0;
    public static int plumCount=0;
    public static int orangeCount=0;
    public static int grapeCount=0;

    public static int totalAppleCount = 0;
    public static int totalBananaCount = 0;
    public static int totalPlumCount = 0;
    public static int totalOrangeCount = 0;
    public static int totalGrapeCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FruitSpawn());
    }


    // Update is called once per frame
    void Update()
    {
         if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
         {
             Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
             RaycastHit hit = new RaycastHit(); ;

            if (Physics.Raycast(ray, out hit))
            {
                if (TextChange.fruitName == "Apple")
                //if (text.GetComponent<UnityEngine.UI.Text>().text.Equals("Apple"))
                {
                    if (hit.transform.gameObject.name == "apple(Clone)")
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        Vector3 touchPosition = mainCamera.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 0f));
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            audio.Play();
                            Instantiate(pop, touchPosition, Quaternion.identity);
                            appleCount++;
                            text.GetComponent<UnityEngine.UI.Text>().text = appleCount.ToString();
                        }
                    }
                    else
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            audioWrongFruit.Play();
                            appleCount--;
                            text.GetComponent<UnityEngine.UI.Text>().text = appleCount.ToString();
                        }
                    }
                }

                if (TextChange.fruitName == "Banana")
                //if (text.GetComponent<UnityEngine.UI.Text>().text.Equals("Banana"))
                {
                    text.GetComponent<UnityEngine.UI.Text>().text = bananaCount.ToString();
                    if (hit.transform.gameObject.name == "banana(Clone)")
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        Vector3 touchPosition = mainCamera.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 0f));
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            audio.Play();
                            Instantiate(pop, touchPosition, Quaternion.identity);
                            bananaCount++;
                            text.GetComponent<UnityEngine.UI.Text>().text = bananaCount.ToString();
                        }
                    }
                    else
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            audioWrongFruit.Play();
                            bananaCount--;
                            text.GetComponent<UnityEngine.UI.Text>().text = bananaCount.ToString();
                        }
                    }
                }


                if (TextChange.fruitName == "Plum")
                //if (text.GetComponent<UnityEngine.UI.Text>().text.Equals("Plum"))
                {
                    text.GetComponent<UnityEngine.UI.Text>().text = plumCount.ToString();
                    if (hit.transform.gameObject.name == "plum(Clone)")
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        Vector3 touchPosition = mainCamera.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 0f));
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            audio.Play();
                            Instantiate(pop, touchPosition, Quaternion.identity);
                            plumCount++;
                            text.GetComponent<UnityEngine.UI.Text>().text = plumCount.ToString();
                        }
                    }
                    else
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            audioWrongFruit.Play();
                            plumCount--;
                            text.GetComponent<UnityEngine.UI.Text>().text = plumCount.ToString();
                        }
                    }
                }

                if (TextChange.fruitName == "Orange")
                //if (text.GetComponent<UnityEngine.UI.Text>().text.Equals("Orange"))
                {
                    text.GetComponent<UnityEngine.UI.Text>().text = orangeCount.ToString();
                    if (hit.transform.gameObject.name == "orange(Clone)")
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        Vector3 touchPosition = mainCamera.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 0f));
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            audio.Play();
                            Instantiate(pop, touchPosition, Quaternion.identity);
                            orangeCount++;
                            text.GetComponent<UnityEngine.UI.Text>().text = orangeCount.ToString();
                        }
                    }
                    else
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            audioWrongFruit.Play();
                            orangeCount--;
                            text.GetComponent<UnityEngine.UI.Text>().text = orangeCount.ToString();
                        }
                    }
                }

                if (TextChange.fruitName == "Grape")
                //if (text.GetComponent<UnityEngine.UI.Text>().text.Equals("Grape"))
                {
                    text.GetComponent<UnityEngine.UI.Text>().text = grapeCount.ToString();
                    if (hit.transform.gameObject.name == "grape(Clone)")
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        Vector3 touchPosition = mainCamera.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 0f));
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            audio.Play();
                            Instantiate(pop, touchPosition, Quaternion.identity);
                            grapeCount++;
                            text.GetComponent<UnityEngine.UI.Text>().text = grapeCount.ToString();
                        }
                    }
                    else
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            audioWrongFruit.Play();
                            grapeCount--;
                            text.GetComponent<UnityEngine.UI.Text>().text = grapeCount.ToString();
                        }
                    }
                }
            }
         }
    }

    IEnumerator FruitSpawn() 
    {
        while(true)
        {
            var wanted = UnityEngine.Random.Range(min, max);
            var position = new Vector3(wanted, transform.position.y,-1.0f);
            GameObject gameObject= Instantiate(fruits[UnityEngine.Random.Range(0, fruits.Length)], position, Quaternion.identity) as GameObject;

            if (gameObject.name == "apple(Clone)" && TextChange.fruitName == "Apple")
                totalAppleCount++;
            else if (gameObject.name == "banana(Clone)" && TextChange.fruitName == "Banana")
                totalBananaCount++;
            else if (gameObject.name == "plum(Clone)" && TextChange.fruitName == "Plum")
                totalPlumCount++;
            else if (gameObject.name == "orange(Clone)" && TextChange.fruitName == "Orange")
                totalOrangeCount++;
            else if (gameObject.name == "grape(Clone)" && TextChange.fruitName == "Grape")
                totalGrapeCount++;

            yield return new WaitForSeconds(secondsToSpawn);
            Destroy(gameObject, 5f);
        }
    }
}
