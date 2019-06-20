using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YolKontrol : MonoBehaviour {

    public GameObject yol1;
    public GameObject yol2;
  //public GameObject camera;
  // public GameObject karadelik;

    Rigidbody fizik1;
    Rigidbody fizik2;
  //Rigidbody camerafizik;
  //Rigidbody karadelikfizik;

    float uzunluk = 0;
    public int hiz;


	// Use this for initialization
	void Start () {

        //yollara fiziksel bir agırlık verdik
        fizik1 = yol1.GetComponent<Rigidbody>();
        fizik2 = yol2.GetComponent<Rigidbody>();

        //kameramıza da bir agırlık verdik
        //camerafizik = camera.GetComponent<Rigidbody>();

        //karadeliğimizde bizimle birlikte hareket etsin
        //karadelikfizik = karadelik.GetComponent<Rigidbody>();
        

        //yollara bir hız verdik. z konumunda hareket etmeleri için
        fizik1.velocity = new Vector3(0, 0, -1.5f * hiz);
        fizik2.velocity = new Vector3(0, 0, +1.5f * hiz);

        //kameramıza da bir hiz verdik
        //camerafizik.velocity = new Vector3(0, 0, +1.5f * hiz);

        //karadeliğimize de aynı hızı vermemiz lazım
        //karadelikfizik.velocity = new Vector3(0, 0, +1.5f * hiz);

        uzunluk = yol1.GetComponent<BoxCollider>().size.z;
        
	}
	
	// Update is called once per frame
	void Update () {
		if(yol1.transform.position.z <= -uzunluk)
        {
            yol1.transform.position += new Vector3(0, 0, uzunluk * 10);
            //kameramız da yol boyu bizi takip edicek
            //camera.transform.position += new Vector3(0, 0, uzunluk * 10);
            //karadeliğinde posizyonunu yol ve kamera ile aynı durumda ilerletmeliyiz
            //karadelik.transform.position += new Vector3(0, 0, uzunluk * 10);
        }
        if(yol2.transform.position.z <= uzunluk)
        {
            yol2.transform.position += new Vector3(0, 0, uzunluk * 10);
        }
	}
}
