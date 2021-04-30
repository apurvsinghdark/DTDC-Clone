using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulkDeliveryMultipleTick : MonoBehaviour
{
    public Toggle _toggle1;
    public Toggle _toggle2;

    public Button _deliverButton;

    private void Update() {
        
        if(_toggle1.isOn && _toggle2.isOn)
        {
            _deliverButton.interactable = true;
        }
        else
        {
            _deliverButton.interactable = false;
        }
    }
}
