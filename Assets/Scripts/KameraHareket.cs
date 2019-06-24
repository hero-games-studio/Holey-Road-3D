using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraHareket : MonoBehaviour {

    GameObject playerObj; //karadelik objemizi bu objeye atıcaz
    Vector3 cameraOffSet; //kameranın objemize uzaklığını belirlicez

	// Use this for initialization
	void Start () {

        playerObj = GameObject.Find("karaDelik"); //karadelik nesnemizi atadık
        cameraOffSet = new Vector3(0, 110, 0); //kameranın uzaklığını belirledik
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = playerObj.transform.position + cameraOffSet; //kameranın posizyonunu objemizin posizyonuna esitledik ve uzaklığıda ekledik
	}
}
