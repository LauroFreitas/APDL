using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderEventSala : MonoBehaviour
{
    MultiDelegate myMultiDelegate;

    public bool desativar = true;
    public GameObject luz;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            myMultiDelegate += StartCo;
            myMultiDelegate.Invoke(1);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           
        }
    }

    public void StartCo(int ID)
    {
        if (ID == 1)
        {
            StartCoroutine(PlayerPassagem());
        }
        else if (ID == 2)
        {

        }

    }
    IEnumerator PlayerPassagem()
    {
        MetaEventSet.singleton.metaEvents[5].Event.Invoke();
        yield return new WaitForSeconds(4);
        MetaEventSet.singleton.metaEvents[4].Event.Invoke();
        yield return new WaitForSeconds(3);
        MetaEventSet.singleton.metaEvents[6].Event.Invoke();
        yield return new WaitForSeconds(6);
        myMultiDelegate -= StartCo;
    }
}
