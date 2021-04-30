using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScreenFader : MonoBehaviour
{
    public Image image;
    public TMP_Text _text;
    public GameObject _panel;
    private float targetAlpha;
    public float FadeRate;

    void Start()
    {
        //if(_panel.activeSelf)
        Invoke("startFadein",2);
    }

    IEnumerator FadeIn()
    {
        targetAlpha = 0.0f;
        Color curColor = image.color;
        while (Mathf.Abs(curColor.a - targetAlpha) > 0.0001f)
        {
            curColor.a = Mathf.Lerp(curColor.a, targetAlpha, FadeRate * Time.deltaTime);
            image.color = curColor;
            if(_text != null) _text.color = curColor;
            if(image.color.a < 0.1f && _panel != null) _panel.SetActive(false); 
            yield return null;
        }
    }



    void startFadein()
    {
        StartCoroutine(FadeIn());
        StopCoroutine(FadeIn());
    }
}
