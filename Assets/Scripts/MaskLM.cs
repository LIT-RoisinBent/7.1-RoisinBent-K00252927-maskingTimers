using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * The LevelManager from the Week 6 Lecture
 */
public class MaskLM : MonoBehaviour {

    public static MaskLM instance;
    public float gameTitleTime = 2f;
    public Animator gameTitleAnim;
    
    private void Awake()
    {
        instance = this;
        
    }

    void Start()
    {
        StartCoroutine("FadeTimer");
    }

    private IEnumerator FadeTimer()
    {
        yield return new WaitForSeconds(gameTitleTime);
        gameTitleAnim.SetTrigger("Fade");
    }

}
