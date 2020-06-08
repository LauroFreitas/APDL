using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Animator animator;
    public Animator animatorLanterna;
    private bool luzLigada = false;
    public GameObject luz;
    private void Start()
    {
        luz.SetActive(false);
    }
    public void Update()
    {
        LigarLuz();
    }
    private void LigarLuz()
    {
        if (luzLigada == false)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                luzLigada = true;
                animator.SetTrigger("Ligar");
                animatorLanterna.SetTrigger("Ligar");
                luz.SetActive(true);
               
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                luzLigada = false;
                animator.SetTrigger("Desligar");
                animatorLanterna.SetTrigger("Desligar");
                luz.SetActive(false);
               
            }
        }
    }
}