using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowValue : MonoBehaviour
{
    public Text txt;
  
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    public void TextUpdate (float value)
    {
        txt.text = value.ToString();
    }
}
