using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasManager : MonoBehaviour
{
    public int bullets;
    public GameObject bullet_1;
    public GameObject bullet_2;
    public GameObject bullet_3;


    public int scoreValue = 0;
    public TextMeshProUGUI score;

    public Animator anima;
    public GameObject gameoverimage;

    // Start is called before the first frame update
    void Start()
    {

        bullets = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(bullets == 2)
        {
            bullet_3.SetActive(false);
        }
        else if(bullets == 1)
        {
            bullet_3.SetActive(false);
            bullet_2.SetActive(false);
        }
        else if (bullets == 0)
        {
            bullet_1.SetActive(false);
            bullet_2.SetActive(false);  
            bullet_3.SetActive(false);
            endGame();
        }


        score.text = "" + scoreValue;
        
    }

    void endGame()
    {
        anima.SetTrigger("Dog_Sart");
        gameoverimage.SetActive(true);
        
    }

   
}
