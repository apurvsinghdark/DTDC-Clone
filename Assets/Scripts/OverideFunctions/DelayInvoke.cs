using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayInvoke : MonoBehaviour
{
    public List<float> _delayTime = new List<float>();

    private void Start() {
        switch (_delayTime.Count)
        {
            case 1 :
            StartCoroutine(_DelayStart(_delayTime[0]));
            break;
            case 2 :
            StartCoroutine(_DelayStart(_delayTime[0],_delayTime[1]));
            break;
            case 3 :
            StartCoroutine(_DelayStart(_delayTime[0],_delayTime[1],_delayTime[2]));
            break;
            case 4 :
            StartCoroutine(_DelayStart(_delayTime[0],_delayTime[1],_delayTime[2],_delayTime[3]));
            break;
            default:
            break;
        }
    }


    IEnumerator _DelayStart(float _time)
    {
        yield return new WaitForSeconds(_time);
        Debug.Log("Hello");
    }
    IEnumerator _DelayStart(float _time , float _time2)
    {
        yield return new WaitForSeconds(_time);
        Debug.Log("Hello");
        yield return new WaitForSeconds(_time2);
        Debug.Log("World");
    }
    
    IEnumerator _DelayStart(float _time , float _time2, float _time3)
    {
        yield return new WaitForSeconds(_time);
        Debug.Log("Hello");
        yield return new WaitForSeconds(_time2);
        Debug.Log("World");
        yield return new WaitForSeconds(_time3);
        Debug.Log("PPL");
    }
    
    IEnumerator _DelayStart(float _time , float _time2, float _time3, float _time4)
    {
        yield return new WaitForSeconds(_time);
        Debug.Log("Hello");
        yield return new WaitForSeconds(_time2);
        Debug.Log("World");
        yield return new WaitForSeconds(_time3);
        Debug.Log("PPL");
        yield return new WaitForSeconds(_time4);
        Debug.Log("GoodMorning");
    }
}
