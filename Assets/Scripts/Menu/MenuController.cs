using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {


    public Button selBtn;

	// Use this for initialization
	void Start () {
        selBtn.onClick.AddListener(() => GoSel());
        PlayerPrefs.DeleteAll();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    void GoSel()
    {
        selBtn.onClick.RemoveAllListeners();
        SceneManager.LoadScene("Nivel");
    }
}
