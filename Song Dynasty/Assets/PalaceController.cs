using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PalaceController : MonoBehaviour
{

    public Button talkBtn2;
    public Button talkBtn3;
    public GameObject palace;
    public GameObject palaceMaid;
    private float timeCount1;
    private bool timeStart1;

    public GameObject palaceMaidSingle;
    public Button chatBtn;
    public Button handFoodBtn;
    public Text text1;
    private float timeCount2;
    private bool timeStart2;
    public Button marketBtn;
    public GameObject market;
    public Button palaceBtn;

    public Button mountainBtn;
    public GameObject mountain;
    public Button restarantBtn;
    public GameObject restarant;
    public GameObject taskButtonObj;
    void Start()
    {
        talkBtn2 = talkBtn2.GetComponent<Button>();
        talkBtn2.onClick.AddListener(talkButton2);

        talkBtn3 = talkBtn3.GetComponent<Button>();
        talkBtn3.onClick.AddListener(talkButton3);

        handFoodBtn = handFoodBtn.GetComponent<Button>();
        handFoodBtn.onClick.AddListener(handFoodButton);
        chatBtn = chatBtn.GetComponent<Button>();
        chatBtn.onClick.AddListener(chatButton);

        marketBtn = marketBtn.GetComponent<Button>();
        marketBtn.onClick.AddListener(marketButton);
        mountainBtn = mountainBtn.GetComponent<Button>();
        mountainBtn.onClick.AddListener(mountainButton);
        restarantBtn = restarantBtn.GetComponent<Button>();
        restarantBtn.onClick.AddListener(restarantButton);
        palace.SetActive(false);
        palaceMaid.SetActive(false);
        palaceMaidSingle.SetActive(false);
    }

    private void restarantButton()
    {
        restarant.SetActive(true);
        palace.SetActive(false);
        taskButtonObj.SetActive(true);

    }
    private void mountainButton()
    {
        mountain.SetActive(true);
        palace.SetActive(false);
    }

    private void marketButton()
    {
        market.SetActive(true);
        palace.SetActive(false);
    }

    private void chatButton()
    {
        
    }

    private void handFoodButton()
    {
        text1.text = "Sorry, I'm afraid you've got the wrong person...";
        timeStart2 = true;
    }

    private void talkButton3()
    {
        palaceMaid.SetActive(true);
        timeStart1 = true;
    }

    private void talkButton2()
    {
        palaceMaidSingle.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(timeStart1)
        {
            timeCount1 += Time.deltaTime;
        }
        if(timeCount1>=2)
        {
            palaceMaid.SetActive(false);
        }

        if (timeStart2)
        {
            timeCount2 += Time.deltaTime;
        }
        if (timeCount2 >= 2)
        {
            palaceMaidSingle.SetActive(false);
        }
    }
}
