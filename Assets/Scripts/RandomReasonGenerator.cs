using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomReasonGenerator : MonoBehaviour
{
    ReasonID ID;
    public TMP_Text _Text;

    public GameObject _NextButton;

    private void Start() {  
        ID = (ReasonID)Random.Range(1,16);
        print(ID);
    }

    private void Update() {
        ChangeID();
    }

    public void CompareEnumMember(int _IDfromClick)
    {
        if(ID == (ReasonID)_IDfromClick)
        {
            print("True");
            if (PlayerPrefs.GetInt("relationCheck") == 1)
            {
                PlayerPrefs.SetInt("Pts", PlayerPrefs.GetInt("Pts") + 1);
                PlayerPrefs.SetInt("relationCheck", 0);       
            }
            if (PlayerPrefs.GetInt("relationTimeCheck") == 1)
            {
                PlayerPrefs.SetInt("Pts", PlayerPrefs.GetInt("Pts") + 1);
                //PlayerPrefs.SetInt("relationTimeCheck", 0);
            }
            _NextButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            PlayerPrefs.SetInt("relationCheck", 0);
            print("False");
            _NextButton.GetComponent<Button>().interactable = false;
        }
    }

    public void CompareEnumReason(int _IDfromClick)
    {
        if (ID == (ReasonID)_IDfromClick)
        {
            print("True");
            if (PlayerPrefs.GetInt("reasonCheck") == 1)
            {
                PlayerPrefs.SetInt("Pts", PlayerPrefs.GetInt("Pts") + 1);
                PlayerPrefs.SetInt("reasonCheck", 0);
            }
            if (PlayerPrefs.GetInt("reasonTimeCheck") == 1)
            {
                PlayerPrefs.SetInt("Pts", PlayerPrefs.GetInt("Pts") + 1);
                //PlayerPrefs.SetInt("reasonTimeCheck", 0);
            }
            _NextButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            PlayerPrefs.SetInt("reasonCheck", 0);
            print("False");
            _NextButton.GetComponent<Button>().interactable = false;
        }
    }

    void ChangeID()
    {
        switch (ID)
        {
            case ReasonID.one :
            _Text.text = "Pick Reason - CUSTOMER WILL SELF COLLECT";
            break;
            case ReasonID.two :
            _Text.text = "Pick Reason - RECEIVER NOT AVAILABLE";
            break;
            case ReasonID.three :
            _Text.text = "Pick Reason - RECEIVER REFUSED DELIVERY";
            break;
            case ReasonID.four :
            _Text.text = "Pick Reason - RECEIVER SHIFTED FROM GIVEN ADDRESS";
            break;
            case ReasonID.five :
            _Text.text = "Pick Reason - PAPERWORK REQUIRED";
            break;
            case ReasonID.six :
            _Text.text = "Pick Reason - RESTRICTED ENTRY";
            break;
            case ReasonID.seven :
            _Text.text = "Pick Reason - CONSIGNOR REFUSED RTO SHIPMENT";
            break;
            case ReasonID.eight :
            _Text.text = "Pick Reason - RECEIVER WANTS OPEN DELIVERY";
            break;
            case ReasonID.nine :
            _Text.text = "Pick Reason - RECEIVER REFUSED DELIVERY DUE TO DAMAGE";
            break;
            case ReasonID.ten :
            _Text.text = "Pick Reason - LAST DATE OVER FOR SUBMISSION";
            break;
            case ReasonID.eleven :
            _Text.text = "Pick Reason - LOCAL HOLIDAY";
            break;
            case ReasonID.twelve :
            _Text.text = "Pick Reason - CONSIGNMENT LOST";
            break;
            case ReasonID.thirteen :
            _Text.text = "Pick Reason - LAST MILE MISROUTE";
            break;
            case ReasonID.fourteen :
            _Text.text = "Pick Reason - ADDRESS OK BUT NO SUCH PERSON";
            break;
            case ReasonID.fifteen :
            _Text.text = "Pick Reason - AREA NOT SERVICABLE";
            break;
            case ReasonID.sixteen :
            _Text.text = "Pick Reason - OTP NOT GENERATED";
            break;
            default:
            break;
        }
    }
}

[System.Serializable]
public enum ReasonID{
    one = 1,
    two = 2,
    three = 3,
    four = 4,
    five = 5,
    six = 6,
    seven = 7,
    eight = 8,
    nine = 9,
    ten = 10,
    eleven = 11,
    twelve = 12,
    thirteen = 13,
    fourteen = 14,
    fifteen = 15,
    sixteen = 16,
}
