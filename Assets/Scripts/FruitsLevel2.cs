using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsLevel2 : MonoBehaviour
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


    // Start is called before the first frame update
    void Start()
    {
        Fruits.appleCount = 0;
        Fruits.bananaCount = 0;
        Fruits.plumCount = 0;
        Fruits.orangeCount = 0;
        Fruits.grapeCount = 0;

        Fruits.totalAppleCount = 0;
        Fruits.totalBananaCount = 0;
        Fruits.totalPlumCount = 0;
        Fruits.totalOrangeCount = 0;
        Fruits.totalGrapeCount = 0;

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
                if (RandomTextChange.randomFruitName == "Apple")
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
                            Fruits.appleCount++;
                            text.GetComponent<UnityEngine.UI.Text>().text = Fruits.appleCount.ToString();
                        }
                    }
                    else
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            audioWrongFruit.Play();
                            Fruits.appleCount--;
                            text.GetComponent<UnityEngine.UI.Text>().text = Fruits.appleCount.ToString();
                        }
                    }
                }

                if (RandomTextChange.randomFruitName == "Banana")
                //if (text.GetComponent<UnityEngine.UI.Text>().text.Equals("Banana"))
                {
                    text.GetComponent<UnityEngine.UI.Text>().text = Fruits.bananaCount.ToString();
                    if (hit.transform.gameObject.name == "banana(Clone)")
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        Vector3 touchPosition = mainCamera.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 0f));
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            audio.Play();
                            Instantiate(pop, touchPosition, Quaternion.identity);
                            Fruits.bananaCount++;
                            text.GetComponent<UnityEngine.UI.Text>().text = Fruits.bananaCount.ToString();
                        }
                    }
                    else
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            audioWrongFruit.Play();
                            Fruits.bananaCount--;
                            text.GetComponent<UnityEngine.UI.Text>().text = Fruits.bananaCount.ToString();
                        }
                    }
                }


                if (RandomTextChange.randomFruitName == "Plum")
                //if (text.GetComponent<UnityEngine.UI.Text>().text.Equals("Plum"))
                {
                    text.GetComponent<UnityEngine.UI.Text>().text = Fruits.plumCount.ToString();
                    if (hit.transform.gameObject.name == "plum(Clone)")
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        Vector3 touchPosition = mainCamera.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 0f));
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            audio.Play();
                            Instantiate(pop, touchPosition, Quaternion.identity);
                            Fruits.plumCount++;
                            text.GetComponent<UnityEngine.UI.Text>().text = Fruits.plumCount.ToString();
                        }
                    }
                    else
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            audioWrongFruit.Play();
                            Fruits.plumCount--;
                            text.GetComponent<UnityEngine.UI.Text>().text = Fruits.plumCount.ToString();
                        }
                    }
                }

                if (RandomTextChange.randomFruitName == "Orange")
                //if (text.GetComponent<UnityEngine.UI.Text>().text.Equals("Orange"))
                {
                    text.GetComponent<UnityEngine.UI.Text>().text = Fruits.orangeCount.ToString();
                    if (hit.transform.gameObject.name == "orange(Clone)")
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        Vector3 touchPosition = mainCamera.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 0f));
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            audio.Play();
                            Instantiate(pop, touchPosition, Quaternion.identity);
                            Fruits.orangeCount++;
                            text.GetComponent<UnityEngine.UI.Text>().text = Fruits.orangeCount.ToString();
                        }
                    }
                    else
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            audioWrongFruit.Play();
                            Fruits.orangeCount--;
                            text.GetComponent<UnityEngine.UI.Text>().text = Fruits.orangeCount.ToString();
                        }
                    }
                }

                if (RandomTextChange.randomFruitName == "Grape")
                //if (text.GetComponent<UnityEngine.UI.Text>().text.Equals("Grape"))
                {
                    text.GetComponent<UnityEngine.UI.Text>().text = Fruits.grapeCount.ToString();
                    if (hit.transform.gameObject.name == "grape(Clone)")
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        Vector3 touchPosition = mainCamera.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 0f));
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            audio.Play();
                            Instantiate(pop, touchPosition, Quaternion.identity);
                            Fruits.grapeCount++;
                            text.GetComponent<UnityEngine.UI.Text>().text = Fruits.grapeCount.ToString();
                        }
                    }
                    else
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            audioWrongFruit.Play();
                            Fruits.grapeCount--;
                            text.GetComponent<UnityEngine.UI.Text>().text = Fruits.grapeCount.ToString();
                        }
                    }
                }
            }
        }
    }

    IEnumerator FruitSpawn()
    {
        while (true)
        {
            var wanted = UnityEngine.Random.Range(min, max);
            var position = new Vector3(wanted, transform.position.y, -1.0f);
            GameObject gameObject = Instantiate(fruits[UnityEngine.Random.Range(0, fruits.Length)], position, Quaternion.identity) as GameObject;


            if (gameObject.name == "apple(Clone)" && RandomTextChange.randomFruitName == "Apple")
                Fruits.totalAppleCount++;
            else if (gameObject.name == "banana(Clone)" && RandomTextChange.randomFruitName == "Banana")
                Fruits.totalBananaCount++;
            else if (gameObject.name == "plum(Clone)" && RandomTextChange.randomFruitName == "Plum")
                Fruits.totalPlumCount++;
            else if (gameObject.name == "orange(Clone)" && RandomTextChange.randomFruitName == "Orange")
                Fruits.totalOrangeCount++;
            else if (gameObject.name == "grape(Clone)" && RandomTextChange.randomFruitName == "Grape")
                Fruits.totalGrapeCount++;

            yield return new WaitForSeconds(secondsToSpawn);
            Destroy(gameObject, 5f);
        }
    }
}
