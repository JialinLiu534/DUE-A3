using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YiRenController : MonoBehaviour
{
    public GameObject yiren;
    public GameObject dialog1;
    public Button handFoodBtn;
    public Text text1;
    private bool timeStart;
    public float timeCount;
    public GameObject systemDialog;
    void Start()
    {
        handFoodBtn = handFoodBtn.GetComponent<Button>();
        handFoodBtn.onClick.AddListener(handFoodButton);
        yiren.SetActive(false);
        systemDialog.SetActive(false);
    }

    private void handFoodButton()
    {
        text1.text = "It's delicious, thank you.";
        timeStart = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeStart)
        {
            timeCount += Time.deltaTime;
        }

        if(timeCount>=2)
        {
            text1.text = "And...This is the flower basket we gave to the restaurant. Thank you for your help all the time.";
            
        }
        if(timeCount>=6)
        {  
            systemDialog.SetActive(true);
            
            yiren.SetActive(false);
        }

        if(timeCount>=8)
        {
            timeCount = 0;
            timeStart = false;
            systemDialog.SetActive(false);
        }
    }
}
