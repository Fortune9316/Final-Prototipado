using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NivelController : MonoBehaviour {

    public Button paraoYsinPoloBtn;
    public Button izyBtn;
    // Use this for initialization
    void Start () {
        paraoYsinPoloBtn.onClick.AddListener(() => GoGame(1));
        izyBtn.onClick.AddListener(() => GoGame(3));
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void GoGame(int vidas)
    {
        PlayerPrefs.SetInt("Vidas", vidas);
        SceneManager.LoadScene("Game");
    }

   
}
