using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KupKontrol : MonoBehaviour {
   
    public GameObject yol1;
    public GameObject yol2;

    Rigidbody fizik1;
    Rigidbody fizik2;
    float uzunluk = 0;
    public int hiz;

    
    void Start () {
        fizik1 = yol1.GetComponent<Rigidbody>();
        fizik2 = yol2.GetComponent<Rigidbody>();

        fizik1.velocity = new Vector3(0, 0, -1.5f * hiz);
        fizik2.velocity = new Vector3(0, 0, -1.5f * hiz);

        uzunluk = yol1.GetComponent<BoxCollider>().size.z;
    }
	
	
	void Update () {
        if (yol1.transform.position.z <= -uzunluk)
        {
            yol1.transform.position += new Vector3(0, 0, uzunluk * 20);

        }
       else if (yol2.transform.position.z <= -uzunluk)
        {
            yol2.transform.position += new Vector3(0, 0, uzunluk * 20);

        }

    }

}
