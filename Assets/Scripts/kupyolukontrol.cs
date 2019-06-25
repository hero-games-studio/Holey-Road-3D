using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kupyolukontrol : MonoBehaviour
{
    public GameObject yol1;
    

    Rigidbody fizik1;
    public int hiz;
    // Start is called before the first frame update
    void Start()
    {
        //yollara fiziksel bir agırlık verdik
        fizik1 = yol1.GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //yollara bir hız verdik. z konumunda hareket etmeleri için
        fizik1.velocity = new Vector3(0, 0, -1.5f * hiz);
    }
    
}
