using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendingTaskController : ControllerScript
{
    public override void Start()
    {
        base.Start();
    }

    public override IEnumerator _DelayStart(float _time, float _time2)
    {
        yield return new WaitForSeconds(_time);
        playAudio(clip[0]);
        yield return new WaitForSeconds(_time2);
        glow[0].SetActive(true);
    }
}
