using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerScript : MonoBehaviour
{
    public AudioClip[] clip;
    AudioSource source;
    [HideInInspector]
    public bool train;
    public GameObject [] glow;
    public Animator m_animator;

    public List<float> _delayTime = new List<float>();


    public virtual void Start()
    {
        train = (PlayerPrefs.GetInt("train")==1);
        source = GetComponent<AudioSource>();
        if (train)
        {
            foreach (GameObject gl in glow)
            {
                //gl.SetActive(true);
            }
            if (m_animator)
                m_animator.enabled = true;


            #region Switch_CASE
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
                case 5 :
                StartCoroutine(_DelayStart(_delayTime[0],_delayTime[1],_delayTime[2],_delayTime[3],_delayTime[4]));
                break;
                default:
                break;
            }
            #endregion
        }
        else
        {
            foreach(GameObject gl in glow)
            {
                gl.SetActive(false);
            }
            if (m_animator)
                m_animator.enabled = false;

        }
    }
    
    public void playAudio(AudioClip _clip)
    {
        if (train)
        {
            source.Stop();
            source.PlayOneShot(_clip);
        }
        
    }
    public void clickPhoto(GameObject btn)
    {
        btn.SetActive(false);
        ScreenCapture.CaptureScreenshot("proof");
        btn.SetActive(true);
        SceneManager.LoadScene("Delivery Proof");

    }

    public IEnumerator _DelayStart(float _time)
    {
        yield return new WaitForSeconds(_time);
        //ource.PlayOneShot(clip);
        playAudio(clip[0]);
        
    }
    public virtual IEnumerator _DelayStart(float _time , float _time2)
    {
        yield return new WaitForSeconds(_time);

        yield return new WaitForSeconds(_time2);
        
    }
    
    public virtual IEnumerator _DelayStart(float _time , float _time2, float _time3)
    {
        yield return new WaitForSeconds(_time);
        playAudio(clip[0]);
        yield return new WaitForSeconds(_time2);
        glow[0].SetActive(true);
        yield return new WaitForSeconds(_time3);
        Debug.Log("PPL");
    }
    
    public virtual IEnumerator _DelayStart(float _time , float _time2, float _time3, float _time4)
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
    
    public virtual IEnumerator _DelayStart(float _time , float _time2, float _time3, float _time4, float _time5)
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
