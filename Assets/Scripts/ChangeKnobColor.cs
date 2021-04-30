using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeKnobColor : MonoBehaviour
{
    public List<Image> img = new List<Image>();


    IEnumerator ChangeAlltoWhite()
    {
        foreach (var item in img)
        {
            item.color = new Color32(255,255,255,255);
        }
        yield return new WaitForEndOfFrame();
    }

    public void KnobColor(Image knob)
    {
        StartCoroutine(ChangeAlltoWhite());
        knob.GetComponent<Image>().color = new Color32(11,77,248,255);
    }
}
