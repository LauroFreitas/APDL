using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderEventSaida : MonoBehaviour
{
    MultiDelegate myMultiDelegate;
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
            StartCoroutine("PlayerPassagem");
        }
        else if (ID == 2) 
        {
           
        }
       
    }
    IEnumerator PlayerPassagem() 
    {
        MetaEventSet.singleton.metaEvents[1].Event.Invoke();
        GameObject.Find("Player_").GetComponent<PlayerMoviment>().enabled = false;
        GameObject.Find("Panel2").GetComponent<Fade>().FadeStart();

        yield return new WaitForSeconds(3);
        Player.singleton.playerPrefab.transform.Rotate(0, 180, 0);
        GameObject.Find("Player_").GetComponent<PlayerMoviment>().enabled = true;
        this.gameObject.SetActive(false);
        myMultiDelegate -= StartCo;
    }
}
