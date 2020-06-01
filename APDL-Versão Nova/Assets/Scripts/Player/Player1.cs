using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class Player1 : MonoBehaviour
{
    private string RayCastTv = "TVDisable";//seleciona a tag Lanterna para o campo serial
  
    public Camera cam;//area para camera 
    public GameObject TextView;
   
    private void Update()
    {
       RayCast();
    }
    private void RayCast() 
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 20f)) //serve para pegar a posição do alvo e para a lanterna tb
        {
            var selection = hit.transform;

            if (selection.CompareTag(RayCastTv))
            {
                TextView.SetActive(true);
                if (Input.GetKeyDown("e"))
                {
                    MetaEventSet.singleton.metaEvents[8].Event.Invoke();
                    TextView.SetActive(false);
                }
            }
            else 
            {
                TextView.SetActive(false);
            }
        }
        
    }
}
