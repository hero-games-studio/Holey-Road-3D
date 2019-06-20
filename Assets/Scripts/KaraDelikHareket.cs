using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaraDelikHareket : MonoBehaviour {

     private Rigidbody rigidbody;
     private float thrust = 1f;
     private float wallDistance = 18;
    

    private Vector2 lastMousePos;

    Collider nesne; //kuplerle carpısmada etkilenmesi icin
    public float yatay, dikey; //hareket etmek icin
    public int hiz;
    public float minX, maxX, minZ, maxZ; //sınır belirlemek icin

   /* private Vector3 touchPosition;
    private Vector3 direction;
    private float moveSpeed = 10f;*/


    // Use this for initialization
    void Start () {

        //karaDeliğimize bir rigidbody tanımladık
        rigidbody = GetComponent<Rigidbody>();
        nesne = GetComponent<Collider>();
    }

    //mousumuz ile hareket ettirebiliyoruz
   void Update()
    {
        Vector2 deltaPos = Vector2.zero;

        if (Input.GetMouseButton(0))
        {
             Vector2 currentMousePos =(Input.mousePosition + new Vector3(0,0,10f));
             if (lastMousePos == Vector2.zero)
                 lastMousePos = currentMousePos;

             deltaPos = currentMousePos - lastMousePos;
             lastMousePos = currentMousePos;

             Vector3 force = new Vector3(deltaPos.x, 0, deltaPos.y) * thrust;
             //rigidbody.AddForce(force);
             rigidbody.velocity = force;
            
        }
        else
        {
            rigidbody.velocity = Vector2.zero;
           // lastMousePos = Vector2.zero;
           
           
        }
    }

    private void LateUpdate()
    {
        /* Vector3 pos = transform.position;

         if(transform.position.x < -wallDistance)
         {
             pos.x = -wallDistance;

         }else if(transform.position.x > wallDistance)
         {
             pos.x = wallDistance;
         }

         transform.position = pos;

        rigidbody.position = new Vector3
              (
              Mathf.Clamp(rigidbody.position.x, minX, maxX),
              rigidbody.position.y,
              Mathf.Clamp(rigidbody.position.z, minZ, maxZ)
              );*/
        
    }

    //karadelik  hareketlerini yapmıstık ama klavyeden olduğu için olmadı
    /*  void FixedUpdate () {

         //karaDelik nesnemizin hareket etmesi için
             dikey = Input.GetAxis("Vertical");
             yatay = Input.GetAxis("Horizontal");
             rigidbody.AddForce(new Vector3(yatay, 0, dikey) * hiz);


          //karaDelik nesnemizin yoldan cıkmama sınırları
           rigidbody.position = new Vector3
              (
              Mathf.Clamp(rigidbody.position.x, minX, maxX),
              rigidbody.position.y,
              Mathf.Clamp(rigidbody.position.z,minZ,maxZ)
              );  
              
      } */
    /*   
      void OnTriggerEnter(Collider nesne)
       {
           if (nesne.gameObject.tag == "yesilkup")
           {
               Debug.Log(nesne.gameObject.tag);
               nesne.gameObject.SetActive(false);
           }

           //Küpleri yıkıyor ama biz küpleri yıkmasını değil enable'ı nı false etmesini istiyoruz

           else if (nesne.gameObject.tag == "kirmizikup")
           {
               Debug.Log(nesne.gameObject.tag);
               Debug.Log("Game Over");
           }
       }
       */
    //dokunduğumuyere geliyor olmalı ve istediğimiz yere sürükleyebiliyor olmalıyız
    /* private void Update()
     {
         if( Input.touchCount > 0)
         {
             Touch touch = Input.GetTouch(0);
             touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
             touchPosition.z = 0;
             direction = (touchPosition = transform.position);
             rigidbody.velocity = new Vector2(direction.x, direction.y) * moveSpeed;

             if (touch.phase == TouchPhase.Ended)
                 rigidbody.velocity = Vector2.zero;
         }
     } */
}
