using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketController : MonoBehaviour
{
    public Button talkBtn2;
    public Button talkBtn3;
    public GameObject huolang;
    public GameObject yiren;
    public GameObject dialog1;
    public GameObject market;
    public Button handFoodBtn;
    public Button storeBtn;
    public Text text1;
    public GameObject store;
    public Button marketBtn;

    public Button palaceBtn;
    public GameObject palace;

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

        storeBtn = storeBtn.GetComponent<Button>();
        storeBtn.onClick.AddListener(storeButton);

        handFoodBtn = handFoodBtn.GetComponent<Button>();
        handFoodBtn.onClick.AddListener(handFoodButton);

        palaceBtn = palaceBtn.GetComponent<Button>();
        palaceBtn.onClick.AddListener(palaceButton);

        mountainBtn = mountainBtn.GetComponent<Button>();
        mountainBtn.onClick.AddListener(mountainButton);

        restarantBtn = restarantBtn.GetComponent<Button>();
        restarantBtn.onClick.AddListener(restarantButton);
        huolang.SetActive(false);
        dialog1.SetActive(false);
        market.SetActive(false);
    }

    private void restarantButton()
    {
        restarant.SetActive(true);
        market.SetActive(false);
        taskButtonObj.SetActive(true);
    }

    private void mountainButton()
    {
        mountain.SetActive(true);
        market.SetActive(false);
    }

    private void palaceButton()
    {
        palace.SetActive(true);
        market.SetActive(false);
    }

    private void handFoodButton()
    {
        text1.text = "Sorry, I'm afraid you've got the wrong person...";
    }

    private void storeButton()
    {
        store.SetActive(true);
        huolang.SetActive(false);
    }

    private void talkButton3()
    {
        yiren.SetActive(true);
    }

    private void talkButton2()
    {
        huolang.SetActive(true);
        dialog1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
