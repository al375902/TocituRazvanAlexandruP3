using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public Animator anima;
    public  int score = 0;

    public GameObject canvas;
    private CanvasManager canvasManager;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {

        canvas = GameObject.Find("Canvas");
        canvasManager = canvas.GetComponent<CanvasManager>();

        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            {

            missedBullet();
            }
        Debug.Log("Score:" + score);

        if(score%500 == 0 && score!= 0)
        {
            dogUp();
        }
    }

    void missedBullet()
    {
        canvasManager.bullets -= 1;
        audioSource.Play();
    }

    void dogUp()
    {
        anima.SetTrigger("Dog_Sart");
    }
}
