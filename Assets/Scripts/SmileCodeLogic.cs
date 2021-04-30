using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SmileCodeLogic : MonoBehaviour
{
    private int smilecode=808080;
    public TMPro.TMP_InputField smileCodeField;
    public TMPro.TextMeshProUGUI txt;
    public void ResendCode()
    {
        smilecode = 999999;
        txt.text = "New Code is 999999";
        
    }
    public void SubmitCode(GameObject errorPanel)
    {
        int code = int.Parse(smileCodeField.text);
        if (code == smilecode)
        {
            if (PlayerPrefs.GetInt("smileCheck") == 1)
            {
                PlayerPrefs.SetInt("Pts", PlayerPrefs.GetInt("Pts") + 1);
                PlayerPrefs.SetInt("smileCheck", 0);
            }
            if (PlayerPrefs.GetInt("smileTimeCheck") == 1)
            {
                PlayerPrefs.SetInt("Pts", PlayerPrefs.GetInt("Pts") + 1);
                //PlayerPrefs.SetInt("smileCheck", 0);
            }
            Debug.Log(PlayerPrefs.GetInt("Pts"));
            SceneManager.LoadScene("Task Delivered");
        }
        else
        {
            PlayerPrefs.SetInt("smileCheck", 0);
            errorPanel.SetActive(true);
        }
    }

    public void SubmitCodeWithoutNumber(GameObject errorPanel)
    {
        int code = int.Parse(smileCodeField.text);
        if (code == smilecode)
        {
            if (PlayerPrefs.GetInt("smileCheck") == 1)
            {
                PlayerPrefs.SetInt("Pts", PlayerPrefs.GetInt("Pts") + 1);
                PlayerPrefs.SetInt("smileCheck", 0);
            }
            if (PlayerPrefs.GetInt("smileTimeCheck") == 1)
            {
                PlayerPrefs.SetInt("Pts", PlayerPrefs.GetInt("Pts") + 1);
                //PlayerPrefs.SetInt("smileCheck", 0);
            }
            Debug.Log(PlayerPrefs.GetInt("Pts"));
            SceneManager.LoadScene("Task Delivered without phone");
        }
        else
        {
            PlayerPrefs.SetInt("smileCheck", 0);
            errorPanel.SetActive(true);
        }
    }
    public void SubmitCodeBulk(GameObject errorPanel)
    {
        int code = int.Parse(smileCodeField.text);
        if (code == smilecode)
        {
            if (PlayerPrefs.GetInt("smileCheck") == 1)
            {
                PlayerPrefs.SetInt("Pts", PlayerPrefs.GetInt("Pts") + 1);
                PlayerPrefs.SetInt("smileCheck", 0);
            }
            if (PlayerPrefs.GetInt("smileTimeCheck") == 1)
            {
                PlayerPrefs.SetInt("Pts", PlayerPrefs.GetInt("Pts") + 1);
                //PlayerPrefs.SetInt("smileCheck", 0);
            }
            Debug.Log(PlayerPrefs.GetInt("Pts"));
            SceneManager.LoadScene("Task Delivered bulk delivery");
        }
        else
        {
            PlayerPrefs.SetInt("smileCheck", 0);
            errorPanel.SetActive(true);
        }
    }
    
}
