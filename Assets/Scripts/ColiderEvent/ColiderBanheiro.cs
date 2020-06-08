using System.Collections;
using System.Collections.Generic;
using UnityEngine;

delegate void MultiDelegate(int ID);
public class ColiderBanheiro : MonoBehaviour 
{
    MultiDelegate myMultiDelegate;

    public bool desativar = true;
    public GameObject luz;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           // myMultiDelegate += StartCo;
            //myMultiDelegate.Invoke(1);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           // luz.SetActive(false);
        }
    }

    public void StartCo(int ID) 
    {
        if (ID == 1) 
        {
         //   StartCoroutine(PlayerPassagem());
        }
        else if (ID == 2) 
        {
        
        }
        
    }
    /*
   IEnumerator PlayerPassagem()
   {

       MetaEventSet.singleton.metaEvents[2].Event.Invoke();
       yield return new WaitForSeconds(8);
       luz.SetActive(false);
       this.gameObject.SetActive(false);
       MetaEventSet.singleton.metaEvents[3].Event.Invoke();
       myMultiDelegate -= StartCo;
      
    }
 */
}
