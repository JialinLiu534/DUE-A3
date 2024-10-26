using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemDiaog : MonoBehaviour
{
    float timeCount;
    bool timeStart;
    public GameObject flowerBasket;
    public GameObject sText1;
    public GameObject sText2;
    public GameObject sText3;
    public GameObject sText4;
    void Start()
    {
        timeStart = true;
        sText3.SetActive(false);
        sText4.SetActive(false);

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
            flowerBasket.SetActive(false);
            sText1.SetActive(false);
            sText2.SetActive(false);
            sText3.SetActive(true);
            sText4.SetActive(true);
            timeCount = 0;
            timeStart = false;
        }
        
    }
}
