using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SpawnEnemys : MonoBehaviour {

    // Use this for initialization
    public List<GameObject> enemys;
    public Text newWaveTxt;

    private float maxX, minX;
    private float cont;
    private int contEnemys;
    private int limitEnemys;
    void Start () {
        setBoundsXY();
        cont = 0f;
        contEnemys = 0;
        limitEnemys = 10;
	}
	
	// Update is called once per frame
	void Update () {
        cont += Time.deltaTime;
        if(cont >= 0.6f)
        {
            SpawnEnemy();
            cont = 0f;
        }
        if(contEnemys == limitEnemys)
        {
            newWaveTxt.text = "New Wave";
            Invoke("NewGame", 5f);
            contEnemys++;
        }
	}

    public void SpawnEnemy()
    {
        while (contEnemys <limitEnemys)
        {
            int index = Random.Range(0, 11);
            if (!enemys[index].activeInHierarchy)
            {
                enemys[index].SetActive(true);
                enemys[index].transform.position = new Vector3(Random.Range(minX, maxX), transform.position.y, transform.position.z);
                contEnemys++;
                break;
            }
        }
    }


    public void NewGame()
    {
        newWaveTxt.text = "";
        contEnemys = 0;
        limitEnemys *= 2;
    }
    void setBoundsXY()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(
            Screen.width, Screen.height, 0));
        maxX = bounds.x - 0.5f;
        minX = -bounds.x + 0.5f;
    }
}
