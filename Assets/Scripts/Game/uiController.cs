using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class uiController : MonoBehaviour {

    public Text puntajeTxt;
    public Text vidaTxt;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        puntajeTxt.text = "Puntaje: " + PlayerPrefs.GetInt("Puntaje", 0);
        vidaTxt.text = "Vidas: " + NaveController.instance.vida;
	}
}
