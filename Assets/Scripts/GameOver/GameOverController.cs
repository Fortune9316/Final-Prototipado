using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour {

    // Use this for initialization
    public Text puntajeTxt;
    public Button menuBtn;
	void Start () {
        puntajeTxt.text = "Puntaje: " + PlayerPrefs.GetInt("Puntaje");
        menuBtn.onClick.AddListener(() => GoMenu());
	}

    void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
	
}
