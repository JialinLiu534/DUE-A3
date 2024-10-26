using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionController : MonoBehaviour
{
    public Button closeBtn;
    public GameObject option;
    void Start()
    {
        closeBtn = closeBtn.GetComponent<Button>();
        closeBtn.onClick.AddListener(closeButton);
        option.SetActive(false);
    }

    private void closeButton()
    {
        option.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
