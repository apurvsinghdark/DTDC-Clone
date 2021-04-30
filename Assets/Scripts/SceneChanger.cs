using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene(string SceneName)
    {
        Debug.Log(PlayerPrefs.GetInt("Pts") + " " + PlayerPrefs.GetInt("totalPts"));
        SceneManager.LoadScene(SceneName);
        
    }

    public void backScene(string SceneName)
    {
        PlayerPrefs.SetInt("retry",PlayerPrefs.GetInt("retry")+1) ;
        SceneManager.LoadScene(SceneName);
    }

    public void endSceneDelivered(GameObject obj)
    {
        bool train = (PlayerPrefs.GetInt("train") == 1);
        if (train)
        {
            obj.SetActive(true);
            Debug.Log(PlayerPrefs.GetInt("Pts") + " " + PlayerPrefs.GetInt("totalPts"));
        }
        else
        {
            SceneManager.LoadScene("Progress_Details");
            Debug.Log(PlayerPrefs.GetInt("Pts") + " " + PlayerPrefs.GetInt("totalPts"));

        }
    }
    public void exit() { Application.Quit(); }

    public void SetDeliveryType(string type)
    {
        PlayerPrefs.SetString("deliveryType", type);
    }

    public void QuitTheApp()
    {
        Application.Quit();
    }
}
