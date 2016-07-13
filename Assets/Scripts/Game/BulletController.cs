using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

    // Use this for initialization
    private float minX, minY, maxX, maxY;
    void Start () {
        setBoundsXY();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position -= new Vector3(0f, 5f * Time.deltaTime, 0f);
        if(transform.position.y <= minY)
        {
            gameObject.SetActive(false);
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            col.gameObject.SetActive(false);
            int puntaje = PlayerPrefs.GetInt("Puntaje", 0);
            puntaje += 10;
            PlayerPrefs.SetInt("Puntaje", puntaje);
            gameObject.SetActive(false);
        }
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
}
