using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yutma : MonoBehaviour
{
    [SerializeField] private GameObject yol;
    Rigidbody kup;
    public float cekim;
   

    private void Start()
    {
        kup = GetComponent<Rigidbody>();
    }

    //deliğin içine yutma kodu
    private void FixedUpdate()
    {
        float distance = Vector3.Distance(yol.transform.position, transform.position);
        //Debug.Log(distance);
       // Debug.Log(distance);
        if (distance < cekim)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(yol.transform.position.x, transform.position.y, yol.transform.position.z), Time.deltaTime);
        }
    }

    /*void OnTriggerEnter(Collider carpisma)
      {
          if (carpisma.gameObject.tag == "ball")
          {
              Debug.Log("küpler yok oluyor");
              Destroy(gameObject);
          }
      }*/

}
