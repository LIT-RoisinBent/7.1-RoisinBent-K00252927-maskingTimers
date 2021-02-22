using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class TimerSliderController : MonoBehaviour
{
    public float timerValue = 10f;
    public float updateFrequency = 1f;
    private Slider theSlider;
    private float elapsedTimeInterval = 0f;
    private bool timerOn = false;

    private void Awake()
    {
        theSlider = GetComponent<Slider>();
        theSlider.maxValue = timerValue;
        gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        theSlider.value = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            elapsedTimeInterval += Time.deltaTime; //deltaTime starts when game starts, goes by frame update
        
            if (elapsedTimeInterval >= updateFrequency) //if bigger or equal to frequency
            {
                theSlider.value += updateFrequency; //add frequency to slider value 
                elapsedTimeInterval = 0; //reset timer
            }
        }
    }

    public void StartTimer()
    {
        gameObject.SetActive(true);
        elapsedTimeInterval = 0f;
        theSlider.value = 0f;
        timerOn = true;
    }
    
    public void StopTimer()
    {
        gameObject.SetActive(false);
        elapsedTimeInterval = 0f;
        theSlider.value = 0f;
        timerOn = false;
    }
    
    public void TogglePause()
    {
        timerOn = !timerOn; //sets to opposite of what bool is
    }
}
