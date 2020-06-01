using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene1 : MonoBehaviour
{
    public GameObject player;
    public void Start()
    {
        StartCoroutine("Ativar");
        
    }
    public IEnumerator Ativar()
    {
        gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        MetaEventSet.singleton.metaEvents[0].Event.Invoke();
        yield return new WaitForSeconds(20);
        gameObject.SetActive(false);
        player.SetActive(true);
    }
}
