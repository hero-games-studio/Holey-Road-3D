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

    public int toplam = 0;

    public bool isSuper;


    private void Start()
    {
        isSuper = false;
        kupsayisi = toplamKup;
        sayiText.text = kupsayisi + "/" + toplamKup;
        
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
