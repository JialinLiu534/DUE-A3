using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startController : MonoBehaviour
{
    public Button startBtn;
    public Button optionBtn;
    public Button continueBtn;
    public GameObject start;
    public GameObject option;
    public GameObject chooseGender;
    public GameObject Game;
    public AudioSource musicStart;
    public AudioSource musicGame;
    public Slider volumeSlider;
    void Start()
    {
        startBtn = startBtn.GetComponent<Button>();
        startBtn.onClick.AddListener(startButton);

        optionBtn = optionBtn.GetComponent<Button>();
        optionBtn.onClick.AddListener(optionButton);

        //volumeSlider = volumeSlider.GetComponent<Slider>();
        musicStart = musicStart.GetComponent<AudioSource>();
        musicGame = musicGame.GetComponent<AudioSource>();



    }

    private void optionButton()
    {
        option.SetActive(true);
    }

    private void startButton()
    {
        chooseGender.SetActive(true);
        Game.SetActive(true);
        start.SetActive(false);
        musicStart.Stop();
        musicGame.Play();
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
