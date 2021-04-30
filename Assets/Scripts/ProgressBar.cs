using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProgressBar : MonoBehaviour
{
    string _deliveryType;
    public int maximumAmt;
    public int currentAmt;
    private int stepSkip;
    private int retryStep;

    public GameObject conPanel;

    public TMP_Text points;
    public TMP_Text _deliType;
    public TMP_Text _skipSteps;
    public TMP_Text _retrySteps;

    public float fillSpeed = 0.5f;
    private float targetProgress = 0;

    public Image[] mask;

    private void Start() {
        //PlayerPrefs.SetInt("Pts",0);
        
        currentAmt = PlayerPrefs.GetInt("Pts");
        maximumAmt = PlayerPrefs.GetInt("totalPts");
        stepSkip = PlayerPrefs.GetInt("TLE");
        retryStep = PlayerPrefs.GetInt("retry");

        _deliveryType = PlayerPrefs.GetString("deliveryType");
        
        //print(PlayerPrefs.GetInt("Pts"));

        CurrentFill();


        _skipSteps.text = ($"{stepSkip} times");
        _retrySteps.text = ($"{retryStep} times");

    }

    private void Update() {
        
        foreach(var _image in mask)
        {
            if(_image.fillAmount < targetProgress)
            {
                _image.fillAmount += fillSpeed * Time.deltaTime;


                
                string progress = (Mathf.Floor(_image.fillAmount * 100)).ToString();
                points.text = progress;
            }
        }

        if(targetProgress < (float)currentAmt)
        {
            
        }
    }
    void CurrentFill()
    {
        
        float _fillAmt = (float)currentAmt/(float)maximumAmt;
        targetProgress = _fillAmt;

        //StartCoroutine(OpenCongratulationPanel());
    }

    public void OpenCongratulationPanel()
    {
        conPanel.SetActive(true);
        _deliType.text = ($"DELIVERY TYPE - {_deliveryType}");
    }

    private void OnDisable() {
        PlayerPrefs.SetInt("Pts",0);
        PlayerPrefs.SetInt("totalPts",0);
    }
}
