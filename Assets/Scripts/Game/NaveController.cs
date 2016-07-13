using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class NaveController : MonoBehaviour {

    // Use this for initialization
    private float minX, minY, maxX, maxY;


    public List<GameObject> balas;
    public static NaveController instance;
    public Transform spawnPoint;
    public int vida;

    void Awake()
    {
        instance = this;
    }
	void Start () {
        setBoundsXY();
        vida = PlayerPrefs.GetInt("Vidas", 1);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow) || Input.acceleration.y > 0.2f)
        {
            if(transform.position.y < maxY)
            transform.position += new Vector3(0f, 5f * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.acceleration.y < -0.2f)
        {
            if (transform.position.y > minY)
                transform.position -= new Vector3(0f, 5f * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.acceleration.x < -0.2f)
        {
            if (transform.position.x > minX)
                transform.position -= new Vector3(5f * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.acceleration.x > 0.2f)
        {
            if (transform.position.x < maxX)
                transform.position += new Vector3(5f * Time.deltaTime, 0f, 0f);
        }
        if (vida <= 0){
            PlayerPrefs.SetInt("Vida", vida);
            SceneManager.LoadScene("GameOver");
        }
    }

    public void GiveDamage()
    {
        vida--;
    }

    void setBoundsXY()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(
            Screen.width, Screen.height, 0));
        maxX = bounds.x - 0.5f;
        minX = -bounds.x + 0.5f;
        maxY = bounds.y - 0.5f;
        minY = -bounds.y + 0.5f;
    }

    public void ShootBullet()
    {
        while (true)
        {
            int index = Random.Range(0, 11);
            if (!balas[index].activeInHierarchy)
            {
                balas[index].SetActive(true);
                balas[index].transform.position = spawnPoint.position;
                break;
            }
        }
    }
}
