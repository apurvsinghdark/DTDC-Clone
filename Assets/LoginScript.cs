//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginScript : MonoBehaviour
{
    public TMPro.TMP_InputField username;
    public TMPro.TMP_InputField password;
    public TMPro.TMP_InputField organization;
    public GameObject Instructionpanel;
    public GameObject dtdcpanel;
    public GameObject shipsyPanel;
    bool train;
    public void Start()
    {
        train = (PlayerPrefs.GetInt("train") == 1);
        if (train)
        {   
            if(Instructionpanel != null)
                Instructionpanel.SetActive(false);
        }
        else
        {
            if(Instructionpanel != null)
                Instructionpanel.SetActive(true);
        }
    }
    public void login(string SceneName)
    {
        if(username.text.ToLower()=="Sam".ToLower()&& password.text == "Sam1")
        {
            bool log = (PlayerPrefs.GetInt("loginCheck") == 1);
            bool logTime = (PlayerPrefs.GetInt("loginTimeCheck") == 1);
            if (log)
            {
                PlayerPrefs.SetInt("Pts", (PlayerPrefs.GetInt("Pts") + 1));
            }
            if (logTime)
            {
                PlayerPrefs.SetInt("Pts", (PlayerPrefs.GetInt("Pts") + 1));
            }
            SceneManager.LoadScene(SceneName);
            Debug.Log(PlayerPrefs.GetInt("Pts"));


        }
        else
        {
            PlayerPrefs.SetInt("loginCheck", 0);
        }
    }
    public void selectOrg()
    {
        if (organization.text.ToLower() == "dtdc".ToLower() )
        {
            dtdcpanel.SetActive(true);
            shipsyPanel.SetActive(false);
            bool org = (PlayerPrefs.GetInt("orgCheck") == 1);
            bool orgTime = (PlayerPrefs.GetInt("orgTimeCheck") == 1);
            if (org)
            {
                PlayerPrefs.SetInt("Pts", (PlayerPrefs.GetInt("Pts") + 1));
            }
            if (orgTime)
            {
                PlayerPrefs.SetInt("Pts", (PlayerPrefs.GetInt("Pts") + 1));
            }

        }
        else
        {
            PlayerPrefs.SetInt("orgCheck", 0);
        }
    }
}
