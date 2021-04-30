using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dataAnalytics : MonoBehaviour
{
    [SerializeField]
    float timeTaken;
    public string parameter;
    bool train;
    [SerializeField]
    int point;

    private void Start()
    {
        train = (PlayerPrefs.GetInt("train") == 1);
        //backbtn.interactable = true;
        if (train)
            return;
       
        PlayerPrefs.SetInt("totalPts", PlayerPrefs.GetInt("totalPts")+point);

    }

    // Update is called once per frame
    void Update()
    {
        if (train)
            return;
        timeTaken -= Time.deltaTime;
        //Debug.Log(timeTaken);
        if (timeTaken <= 0.0f && (PlayerPrefs.GetInt(parameter)==1))
        {
            PlayerPrefs.SetInt("TLE", PlayerPrefs.GetInt("TLE") + 1);
            PlayerPrefs.SetInt(parameter, 0);
        }
    }

    

    public void assigntime(float time)
    {
        if (train)
            return;
        timeTaken = time;
    }
    public void assignParameter(string param)
    {
        if (!train)
            parameter = param;
    }
    
    public void dashboardCheck(int val)
    {
        if (train)
            return;
        if (PlayerPrefs.GetInt("dashboardTimeCheck") == 1)
        {
            PlayerPrefs.SetInt("Pts", PlayerPrefs.GetInt("Pts") + val);
        }
        Debug.Log(PlayerPrefs.GetInt("dashboardTimeCheck"));   
        if (PlayerPrefs.GetInt("dashboardCheck") == 1)
        {
            if (val == 0)
            {
                PlayerPrefs.SetInt("wrongchoice", PlayerPrefs.GetInt("wrongChoice") + 1);
            }
            PlayerPrefs.SetInt(parameter, 0);
            PlayerPrefs.SetInt("dasboardCheck", 0);
            PlayerPrefs.SetInt("Pts", PlayerPrefs.GetInt("Pts") + val);
        }
        
    }

    public void TaskSelectionCheck(int val)
    {
        if (train)
            return;
        if (PlayerPrefs.GetInt("taskSelectionTimeCheck") == 1)
        {
            PlayerPrefs.SetInt("Pts", PlayerPrefs.GetInt("Pts") + val);
        }
        if (PlayerPrefs.GetInt("taskSelectionCheck") == 1)
        {
            if (val == 0)
            {
                PlayerPrefs.SetInt("wrongchoice", PlayerPrefs.GetInt("wrongChoice") + 1);
            }
            PlayerPrefs.SetInt(parameter, 0);
            PlayerPrefs.SetInt("taskSelectionCheck", 0);
            PlayerPrefs.SetInt("Pts", PlayerPrefs.GetInt("Pts") + val);
        }
        
    }

    public void deliverCheck(int val)
    {
        if (train)
            return;
        if (PlayerPrefs.GetInt("deliverTimeCheck") == 1)
        {
            PlayerPrefs.SetInt("Pts", PlayerPrefs.GetInt("Pts") + val);
        }
        if (PlayerPrefs.GetInt("deliverCheck") == 1)
        {
            if (val == 0)
            {
                PlayerPrefs.SetInt("wrongchoice", PlayerPrefs.GetInt("wrongChoice") + 1);
            }
            PlayerPrefs.SetInt(parameter, 0);
            PlayerPrefs.SetInt("deliverCheck", 0);
            PlayerPrefs.SetInt("Pts", PlayerPrefs.GetInt("Pts") + val);
        }   
    }
    public void photoCheck(GameObject img)
    {
        if (train)
            return;
        if (img.GetComponent<MeshRenderer>().enabled)
        {
            if (PlayerPrefs.GetInt("photoTimeCheck") == 1)
            {
                PlayerPrefs.SetInt("Pts", PlayerPrefs.GetInt("Pts") + 1);
            }
            if (PlayerPrefs.GetInt("photoCheck") == 1)
            {

                PlayerPrefs.SetInt(parameter, 0);
                PlayerPrefs.SetInt("photoCheck", 0);
                PlayerPrefs.SetInt("Pts", PlayerPrefs.GetInt("Pts") + 1);
            }
        }
        else
        {
            PlayerPrefs.SetInt("photoCheck", 0);
        }
    }
    public void proofCheck()
    {
        if (train)
            return;
        if (PlayerPrefs.GetInt("proofTimeCheck") == 1)
        {
            PlayerPrefs.SetInt("Pts", PlayerPrefs.GetInt("Pts") + 1);
            PlayerPrefs.SetInt("proofTimeCheck",0);
        }
       
    }
    
}

