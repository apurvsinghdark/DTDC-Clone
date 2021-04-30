using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WhichDeliveryCheck : MonoBehaviour
{
    public TMP_Text _Text;

    private void OnEnable() {
        CheckDeliveryType();
    }

    void CheckDeliveryType()
    {
        switch (PlayerPrefs.GetString("deliveryType"))
        {
            case "SMILE CODE DELIVERY WITH NUMBER" :
            _Text.text = "CN Number - M83922412";
            break;
            case "SMILE CODE DELIVERY WITHOUT NUMBER" :
            _Text.text = "CN Number - M83922412";
            break;
            case "BULK DELIVERY" :
            _Text.text = "CN Numbers - M83922412 , E14725836";
            break;
            case "CONSIGNMENT UNDELIVERED" :
            _Text.text = "CN Number - M83922412";
            break;
            default:
            break;
        }
    }
}
