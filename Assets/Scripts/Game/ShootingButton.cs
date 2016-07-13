using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ShootingButton : MonoBehaviour, IPointerDownHandler {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnPointerDown(PointerEventData data)
    {
        NaveController.instance.ShootBullet();
    }
}
