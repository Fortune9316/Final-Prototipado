using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    // Use this for initialization
    private float minY, maxY;
    void Start () {
        setBoundsXY();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0f, 5f * Time.deltaTime, 0f);
        if (transform.position.y >= maxY)
        {
            gameObject.SetActive(false);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            NaveController.instance.GiveDamage();
        }
    }
    void setBoundsXY()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(
            Screen.width, Screen.height, 0));
        maxY = bounds.y - 0.5f;
        minY = -bounds.y + 0.5f;
    }
}
