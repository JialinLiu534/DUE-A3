using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MountainController : MonoBehaviour
{
    public Button talkBtn1;
    public Button talkBtn2;
    public GameObject mountain;
    public GameObject yiren;
    public Button leaveBtn;
    public Button marketBtn;
    public GameObject market;
    public Button palaceBtn;
    public GameObject palace;

    public Button mountainBtn;
    public Button restarantBtn;
    public GameObject restarant;
    public GameObject taskButtonObj;
    void Start()
    {
        talkBtn2 = talkBtn2.GetComponent<Button>();
        talkBtn2.onClick.AddListener(talkButton2);

        talkBtn1 = talkBtn1.GetComponent<Button>();
        talkBtn1.onClick.AddListener(talkButton1);

        leaveBtn = leaveBtn.GetComponent<Button>();
        leaveBtn.onClick.AddListener(leaveButton);

        marketBtn = marketBtn.GetComponent<Button>();
        marketBtn.onClick.AddListener(marketButton);
        palaceBtn = palaceBtn.GetComponent<Button>();
        palaceBtn.onClick.AddListener(palaceButton);
        restarantBtn = restarantBtn.GetComponent<Button>();
        restarantBtn.onClick.AddListener(restarantButton);

        mountain.SetActive(false);
        yiren.SetActive(false);
    }

    private void restarantButton()
    {
        restarant.SetActive(true);
        mountain.SetActive(false);
        taskButtonObj.SetActive(true);
    }

    private void palaceButton()
    {
        palace.SetActive(true);
        mountain.SetActive(false);
    }

    private void marketButton()
    {
        market.SetActive(true);
        mountain.SetActive(false);
    }

    private void leaveButton()
    {
        yiren.SetActive(false);
    }

    private void talkButton1()
    {
        
    }

    private void talkButton2()
    {
        yiren.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
