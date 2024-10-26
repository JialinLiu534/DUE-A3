using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject game;
    public GameObject maleHeader;
    public GameObject femaleHeader;
    public Button taskBtn;
    public GameObject task;
    public Button marketBtn;
    public GameObject market;
    public GameObject taskBtnObj;

    public Button palaceBtn;
    public GameObject palace;

    public Button mountainBtn;
    public GameObject mountain;
    public GameObject gameUI;
    public GameObject taskButtonObj;
    void Start()
    {
        game.SetActive(false);
        maleHeader.SetActive(false);
        femaleHeader.SetActive(false);
        taskBtn = taskBtn.GetComponent<Button>();
        taskBtn.onClick.AddListener(taskButton);
        marketBtn = marketBtn.GetComponent<Button>();
        marketBtn.onClick.AddListener(marketButton);

        palaceBtn = palaceBtn.GetComponent<Button>();
        palaceBtn.onClick.AddListener(palaceButton);

        mountainBtn = mountainBtn.GetComponent<Button>();
        mountainBtn.onClick.AddListener(mountainButton);


    }

    private void mountainButton()
    {
        mountain.SetActive(true);
        palace.SetActive(false);
        market.SetActive(false);
        gameUI.SetActive(false);
        taskButtonObj.SetActive(false);
    }

    private void palaceButton()
    {
        palace.SetActive(true);
        market.SetActive(false);
        mountain.SetActive(false);
        gameUI.SetActive(false);
        taskButtonObj.SetActive(false);
    }

    private void marketButton()
    {
        market.SetActive(true);
        palace.SetActive(false);
        mountain.SetActive(false);
        gameUI.SetActive(false);
        taskButtonObj.SetActive(false);
    }

    private void taskButton()
    {
        task.SetActive(true);
        //taskBtnObj.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(ChooseController.isMale)
        {
            maleHeader.SetActive(true);
        }
        else if(ChooseController.isFemale)
        {
            femaleHeader.SetActive(true);
        }
    }


}
