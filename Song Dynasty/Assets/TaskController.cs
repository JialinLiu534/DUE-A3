using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskController : MonoBehaviour
{
    public Button acceptBtn;
    public Button awardBtn;
    public Button closeBtn;
    public GameObject task;
    public GameObject market;
   
    void Start()
    {
        acceptBtn = acceptBtn.GetComponent<Button>();
        acceptBtn.onClick.AddListener(acceptButton);

        awardBtn = awardBtn.GetComponent<Button>();
        awardBtn.onClick.AddListener(awardButton);

        closeBtn = closeBtn.GetComponent<Button>();
        closeBtn.onClick.AddListener(closeButton);

        task.SetActive(false);
    }

    private void closeButton()
    {
        task.SetActive(false);
    }

    private void awardButton()
    {
        //dialog1.SetActive(true);
    }

    private void acceptButton()
    {
        //task.SetActive(false);
        //market.SetActive(true);
    }

    
    void Update()
    {
        
    }
}
