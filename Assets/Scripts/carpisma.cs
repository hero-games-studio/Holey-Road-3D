using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carpisma : MonoBehaviour
{
    [SerializeField]
    Light isik1;
 

    int toplamKup = 27;
    int kupsayisi;
    [SerializeField]
    private Text sayiText;

    [SerializeField]
    int toplam = 0;
    

    private void Start()
    {
        kupsayisi = toplamKup;
        sayiText.text = kupsayisi + "/" + toplamKup;
        
    }

    void Update()
    {
        if (toplam >= 100)
        {
            Debug.Log("superball aktif");
            GetComponent<yutma>().cekim = 500f;
            GetComponent<yutma>().cekim2 = 2f;
            GetComponent<yutma>().hiz = 10f;


        }
    }


    //küpler kara deliğe düsünce orada destroy oluyorlar
    void OnTriggerEnter(Collider carpisma)
    {
       
        //mavi küpe carptığında olucaklar
        if (carpisma.gameObject.tag == "mavikup")
        {
            kupsayisi--;
            sayiText.text = kupsayisi + "/" + toplamKup;
            toplam += carpisma.GetComponent<yutma>().sayi;
            carpisma.gameObject.SetActive(false);
            Destroy(carpisma.gameObject, 0);
            isik1.intensity += 200f;
            isik1.range += 4f;
            
        }

        //kirmizi kupe carptığında olucaklar
        //kirmizi küpe carptığında game over ekranı gelmesi
        else if (carpisma.gameObject.tag == "kirmizikup")
        {
            Debug.Log("GameOver");
            toplam -= carpisma.GetComponent<yutma>().sayi;
            Destroy(carpisma.gameObject, 0);
            isik1.intensity -= 100f;
            isik1.range -= 2f;
        }
        Debug.Log(toplam);

        
    } 

    
}
