using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class yutma : MonoBehaviour
{

    carpisma carp;

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

    public float saniye;
    bool superball;

    private float defCekim;
    private float defCekim2;
    private float defHiz;
    private string defTag;

    [SerializeField] float supCekim;
    [SerializeField] float supCekim2;
    [SerializeField] float supHiz;
    private string supTag = "mavikup";
    private int lastSUPER;
    

    private void Start()
    {
        lastSUPER = 0;
        carp = PlayerManager.Instance.player.GetComponentInChildren<carpisma>();
        defCekim = cekim;
        defCekim2 = cekim2;
        defHiz = hiz;
        defTag = gameObject.tag;

        kup = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
       
       
        
        if (carp.toplam % 100 == 0 && carp.toplam > 0 && carp.toplam / 100 != lastSUPER)
        {

            lastSUPER = carp.toplam / 100;
            superaktif();
            Invoke("superdeaktif", saniye);

            //    Debug.Log("superball yasasınnnn");
            //    transform.gameObject.tag = "mavikup"; //superballa gecince tüm objelerin taglerini mavikup yaptım
            //    Debug.Log("kırmızı kupe degdik");
            //    cekim = 300f;
            //    cekim2 = 4f;
            //    hiz = 0.3f;

        }
        
    }

    void superdeaktif()
    {
        carp.isSuper = false;
        cekim = defCekim;
        cekim2 = defCekim2;
        hiz = defHiz;
        transform.gameObject.tag = defTag;
    }


    void superaktif()
    {
        carp.isSuper = true;
        Debug.Log("superball yasasınnnn");
        transform.gameObject.tag = supTag; //superballa gecince tüm objelerin taglerini mavikup yaptım
        cekim = supCekim;
        cekim2 = supCekim2;
        hiz = supHiz;
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

}
