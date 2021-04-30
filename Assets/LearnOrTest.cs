using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LearnOrTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("train", 0);
    }
    public void train()
    {
        PlayerPrefs.SetInt("train", 1);
        SceneManager.LoadScene("Delivery selection");
    }
    public void test()
    {
        PlayerPrefs.SetInt("train", 0);
        PlayerPrefs.SetInt("Pts", 0);
        PlayerPrefs.SetInt("totalPts", 0);
        PlayerPrefs.SetInt("TLE", 0);
        PlayerPrefs.SetInt("retry", 0);
        PlayerPrefs.SetInt("wrongChoice", 0);
        PlayerPrefs.SetInt("orgCheck", 1);
        PlayerPrefs.SetInt("orgTimeCheck", 1);
        PlayerPrefs.SetInt("loginCheck", 1);
        PlayerPrefs.SetInt("loginTimeCheck", 1);
        PlayerPrefs.SetInt("dashboardCheck", 1);
        PlayerPrefs.SetInt("dashboardTimeCheck", 1);
        PlayerPrefs.SetInt("taskSelectionCheck", 1);
        PlayerPrefs.SetInt("taskSelectionTimeCheck", 1);
        PlayerPrefs.SetInt("reasonCheck", 1);
        PlayerPrefs.SetInt("reasonTimeCheck", 1);
        PlayerPrefs.SetInt("relationCheck", 1);
        PlayerPrefs.SetInt("relationTimeCheck", 1);
        PlayerPrefs.SetInt("deliverCheck", 1);
        PlayerPrefs.SetInt("deliverTimeCheck", 1);
        PlayerPrefs.SetInt("smileCheck", 1);
        PlayerPrefs.SetInt("smileTimeCheck", 1);
        PlayerPrefs.SetInt("photoCheck", 1);
        PlayerPrefs.SetInt("photoTimeCheck", 1);
        PlayerPrefs.SetInt("proofTimeCheck", 1);
        SceneManager.LoadScene("Delivery selection");
    }

    
}
