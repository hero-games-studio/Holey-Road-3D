using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class TouchLogic : MonoBehaviour
{
  //public float wallDistance;
    public float hiz;

    void Start()
    {
       
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                // agent.SetDestination(hit.point);
                Vector3 target = Vector3.Lerp(transform.position, hit.point, hiz*Time.deltaTime);
                transform.position = new Vector3(target.x, transform.position.y, target.z);
            }
        }
    }
  
    /*  private void LateUpdate()
    {
        Vector3 pos = transform.position;

        if (transform.position.x < -wallDistance)
        {
            pos.x = -wallDistance;

        }
        else if (transform.position.x > wallDistance)
        {
            pos.x = wallDistance;
        }

        transform.position = pos;
    }*/
}
