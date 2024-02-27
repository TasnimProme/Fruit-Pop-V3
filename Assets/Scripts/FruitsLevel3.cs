using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsLevel3 : MonoBehaviour
{
    [SerializeField] GameObject[] fruits;
    [SerializeField] float secondsToSpawn;
    [SerializeField] float min;
    [SerializeField] float max;
    [SerializeField] GameObject scoreText;
    [SerializeField] GameObject pop;

    [SerializeField] AudioSource audio;
    [SerializeField] AudioSource audioWrongFruit;

    public Camera mainCamera;

    public static int appleCount = 0;
    public static int otherFruitCount = 0;

    public static int totalApple = 0;
    public static int totalOtherFruit = 0;

    int score = 0;
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
                        score++;
                        scoreText.GetComponent<UnityEngine.UI.Text>().text = score.ToString();
                    }
                }
                else if (hit.transform.gameObject.name == "angryOrange(Clone)")
                {
                    BoxCollider bc = hit.collider as BoxCollider;
                    Vector3 touchPosition = mainCamera.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 0f));
                    if (bc != null)
                    {
                        Destroy(bc.gameObject);
                        audio.Play();
                        Instantiate(pop, touchPosition, Quaternion.identity);
                        otherFruitCount = otherFruitCount + 1;
                        score = score + 5;
                        scoreText.GetComponent<UnityEngine.UI.Text>().text = score.ToString();
                    }
                }
                else if (hit.transform.gameObject.name == "happyBanana(Clone)")
                {
                    BoxCollider bc = hit.collider as BoxCollider;
                    Vector3 touchPosition = mainCamera.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 0f));
                    if (bc != null)
                    {
                        Destroy(bc.gameObject);
                        audio.Play();
                        Instantiate(pop, touchPosition, Quaternion.identity);
                        otherFruitCount = otherFruitCount + 1;
                        score = score + 5;
                        scoreText.GetComponent<UnityEngine.UI.Text>().text = score.ToString();
                    }
                }
                else
                {
                    BoxCollider bc = hit.collider as BoxCollider;
                    if (bc != null)
                    {
                        Destroy(bc.gameObject);
                        audioWrongFruit.Play();
                        score--;
                        scoreText.GetComponent<UnityEngine.UI.Text>().text = score.ToString();
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

            if (gameObject.name == "apple(Clone)")
                totalApple++;
            else if (gameObject.name == "angryOrange(Clone)" || gameObject.name == "happyBanana(Clone)")
                totalOtherFruit++;

            yield return new WaitForSeconds(secondsToSpawn);
            Destroy(gameObject, 5f);
        }
    }
}
