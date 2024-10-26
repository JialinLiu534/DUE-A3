using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreController : MonoBehaviour
{
    public GameObject store;
    public Button closeBtn;
    public Button chooseBtn;
    public Text moneyText;
    public Text powerText;
    void Start()
    {
        closeBtn = closeBtn.GetComponent<Button>();
        closeBtn.onClick.AddListener(closeButton);
        chooseBtn = chooseBtn.GetComponent<Button>();
        chooseBtn.onClick.AddListener(chooseButton);
        store.SetActive(false);
    }

    private void chooseButton()
    {
        
        moneyText.text = (int.Parse(moneyText.text) - 50).ToString();
        powerText.text = (int.Parse(powerText.text) + 15).ToString();
    }

    private void closeButton()
    {
        store.SetActive(false);
    }

    
    void Update()
    {
        
    }
}
