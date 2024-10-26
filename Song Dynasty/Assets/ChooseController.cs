using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseController : MonoBehaviour
{
    public Button maleBtn;
    public Button femaleBtn;
    public GameObject chooseGender;
    public GameObject game;
    public static bool isMale;
    public static bool isFemale;
    void Start()
    {
        maleBtn = maleBtn.GetComponent<Button>();
        maleBtn.onClick.AddListener(maleButton);

        femaleBtn = femaleBtn.GetComponent<Button>();
        femaleBtn.onClick.AddListener(femaleButton);

        chooseGender.SetActive(false);

        
    }

    private void femaleButton()
    {
        chooseGender.SetActive(false);
        isFemale = true;

    }

    private void maleButton()
    {
        chooseGender.SetActive(false);
        isMale = true;
    }

    void Update()
    {
        
    }
}
