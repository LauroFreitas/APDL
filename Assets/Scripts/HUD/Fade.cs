using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public Image img;
    float fadeTime = 6f;
    Color fade;

   public void FadeStart()
   {
        img.enabled = true;
        fade = new Color(1f, 1f, 1f, 0f);
        img.CrossFadeColor(fade, fadeTime, true, true);
   }
}