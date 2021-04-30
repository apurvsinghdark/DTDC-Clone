using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class relationshipCheck : MonoBehaviour
{
    public TMPro.TMP_InputField _name;
    public TMPro.TMP_InputField number;

    public void checkRelation()
    {
        if(_name.text.ToLower()=="rohit kumar".ToLower() && number.text== "8327835178")
        {
            SceneManager.LoadScene("Camera_Scene");
        }
    }

}
