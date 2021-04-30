using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionController : MonoBehaviour
{
    public GameObject[] otherButtons;
    
    public void selectRelation(GameObject thisButton)
    {
        foreach (GameObject btn in otherButtons)
        {
            btn.transform.GetChild(0).gameObject.SetActive(false);
            btn.transform.GetChild(1).gameObject.GetComponent<TMPro.TextMeshProUGUI>().color = new Color(0, 0, 0, 255);
        }
        thisButton.transform.GetChild(0).gameObject.SetActive(true);
        thisButton.transform.GetChild(1).gameObject.GetComponent<TMPro.TextMeshProUGUI>().color = new Color(255, 255, 255, 255);
    }
}
