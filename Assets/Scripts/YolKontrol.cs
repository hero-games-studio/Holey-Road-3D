using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YolKontrol : MonoBehaviour {

    public GameObject yol1;
    
  //public GameObject camera;
  // public GameObject karadelik;

    Rigidbody fizik1;
    
  //Rigidbody camerafizik;
  //Rigidbody karadelikfizik;

    
    public int hiz;


	// Use this for initialization
	void Start () {

        //yollara fiziksel bir agırlık verdik
        fizik1 = yol1.GetComponent<Rigidbody>();
        //yollara bir hız verdik. z konumunda hareket etmeleri için
        fizik1.velocity = new Vector3(0, 0, -1.5f * hiz);


        //kameramıza da bir agırlık verdik
        //camerafizik = camera.GetComponent<Rigidbody>();

        //karadeliğimizde bizimle birlikte hareket etsin
        //karadelikfizik = karadelik.GetComponent<Rigidbody>();





        //kameramıza da bir hiz verdik
        //camerafizik.velocity = new Vector3(0, 0, +1.5f * hiz);

        //karadeliğimize de aynı hızı vermemiz lazım
        //karadelikfizik.velocity = new Vector3(0, 0, +1.5f * hiz);

        // uzunluk = yol1.GetComponent<BoxCollider>().size.z;


    }
	
	
}
