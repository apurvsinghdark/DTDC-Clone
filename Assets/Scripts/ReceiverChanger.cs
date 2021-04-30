using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReceiverChanger : MonoBehaviour
{
    ReceiverNameID ID;
    public TMP_Text _Text; //Small Panel
    public TMP_Text _HintText; // Front Panel

    public GameObject _NextButton;

    private void Start() {  
        ID = (ReceiverNameID)Random.Range(1,7);
        _HintText.text = ($"Customer isn't available, {ID.ToString()} is available to receive, handover him/her the package.");
        print(ID);
    }

    private void Update() {
        ChangeID();
    }

    public void CompareEnumMember(int _IDfromClick)
    {
        if(ID == (ReceiverNameID)_IDfromClick)
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
                PlayerPrefs.SetInt("relationTimeCheck", 0);
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

    void ChangeID()
    {
        switch (ID)
        {
            case ReceiverNameID.Family :
            _Text.text = "Family Name - ROHIT KUMAR";
            break;
            case ReceiverNameID.Friend :
            _Text.text = "Friend Name - ROHIT KUMAR";
            break;
            case ReceiverNameID.Neighbour :
            _Text.text = "Neighbour Name - ROHIT KUMAR";
            break;
            case ReceiverNameID.OfficeColleague :
            _Text.text = "OfficeColleague Name - ROHIT KUMAR";
            break;
            case ReceiverNameID.Receptionist :
            _Text.text = "Receptionist Name - ROHIT KUMAR";
            break;
            case ReceiverNameID.Relative :
            _Text.text = "Relative Name - ROHIT KUMAR";
            break;
            case ReceiverNameID.SecurityGuard :
            _Text.text = "SecurityGuard Name - ROHIT KUMAR";
            break;
            default:
            break;
        }
    }
}

[System.Serializable]
public enum ReceiverNameID{
    Family = 1,
    Friend = 2,
    Neighbour = 3,
    OfficeColleague = 4,
    Receptionist = 5,
    Relative = 6,
    SecurityGuard = 7,
}
