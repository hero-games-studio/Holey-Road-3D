using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpisma : MonoBehaviour
{
    //küpler kara deliğe düsünce orada destroy oluyorlar
    void OnTriggerEnter(Collider carpisma)
    {
        if (carpisma.gameObject.tag == "ball")
        {
           // Debug.Log(carpisma.gameObject);
            Destroy(carpisma.gameObject, 0);
            
        }
    } 
}
