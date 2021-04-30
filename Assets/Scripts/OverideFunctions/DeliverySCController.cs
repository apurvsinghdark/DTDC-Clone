using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeliverySCController : ControllerScript
{
    [Space(10)]
    public Button _resendButton;
    public GameObject _OTPPanel;
    public override void Start()
    {
        base.Start();
        
        if(!train)
        {
            _resendButton.interactable = true;
            _OTPPanel.SetActive(true);
        }

    }

    public override IEnumerator _DelayStart(float _time , float _time2, float _time3)
    {
        yield return new WaitForSeconds(_time);
        playAudio(clip[0]);
        yield return new WaitForSeconds(_time2);
        glow[0].SetActive(true);
        yield return new WaitForSeconds(_time3);
        _resendButton.interactable = true;
        glow[0].SetActive(false);
        glow[1].SetActive(true);
        _OTPPanel.SetActive(true);
       
        //glow[1].SetActive(false);
        //glow[1].SetActive(false);
        //playAudio(clip[1]);
    }
}
