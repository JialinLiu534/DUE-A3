using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public AudioSource musicStart;
    public AudioSource musicGame;
    public Slider volumeSlider;
    public static float value;
    void Start()
    {
        volumeSlider= volumeSlider.GetComponent<Slider>();
        musicStart = musicStart.GetComponent<AudioSource>();
        musicGame = musicGame.GetComponent<AudioSource>();
    }



    void Update()
    {
        musicStart.volume = volumeSlider.value;
        //value= volumeSlider.value;
        musicGame.volume = volumeSlider.value;
    }

    public void Volumn()
    {
        
    }
}
