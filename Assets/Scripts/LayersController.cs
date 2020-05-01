using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LayersController : MonoBehaviour
{
    public GameObject blocos;
    public GameObject blocosWF;
    public GameObject blocosintersect;
    public Slider slider;


    void Start()
    {

        foreach (Transform child in blocos.transform)
        {
            child.gameObject.SetActive(false);
        }
        blocos.transform.Find("1").gameObject.SetActive(true);

        foreach (Transform child in blocosWF.transform)
        {
            child.gameObject.SetActive(false);
        }
        blocosWF.transform.Find("1").gameObject.SetActive(true);

        foreach (Transform child in blocosintersect.transform)
        {
            child.gameObject.SetActive(false);
        }

    }

    void OnGUI()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            slider.value -= 1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            slider.value += 1;
        }
    }



    public void ShowLayer(float value)
    {
        foreach (Transform child in blocos.transform)
        {
            child.gameObject.SetActive(false);
        }

        foreach (Transform child in blocosWF.transform)
        {
            child.gameObject.SetActive(false);
        }

        foreach (Transform child in blocosintersect.transform)
        {
            child.gameObject.SetActive(false);
        }

        blocos.transform.Find(value.ToString()).gameObject.SetActive(true);
        blocosWF.transform.Find(value.ToString()).gameObject.SetActive(true);
        blocosintersect.transform.Find((value-1f).ToString()).gameObject.SetActive(true);
        
    }
}
