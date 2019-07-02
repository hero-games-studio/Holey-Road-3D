using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yutma : MonoBehaviour
{
    [SerializeField] private GameObject yol;
    Rigidbody kup;
    public float cekim;
    public float cekim2;
    public float yukseklikFarki;
    private float normalYukseklik;
    public float hiz;

    private bool firstHit = false;

    [SerializeField]
    public int sayi = 10;

    private void Start()
    {
        kup = GetComponent<Rigidbody>();
    }

    //deliğin içine yutma kodu
    private void FixedUpdate()
    {
        float distance = Vector3.Distance(yol.transform.position, transform.position);
        float yukseklik = Mathf.Abs(normalYukseklik - transform.position.y);
        //Debug.Log(yukseklik);
        // Debug.Log(distance);
        if (distance < cekim && distance > cekim2 && yukseklik < yukseklikFarki)
        {
            transform.position = Vector3.Lerp(transform.position, yol.transform.position, Time.deltaTime * hiz);
            
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!firstHit)
        {
            firstHit = true;
            normalYukseklik = transform.position.y;
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
