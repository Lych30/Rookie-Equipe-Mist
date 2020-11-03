﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2DifficultyManagement : MonoBehaviour
{
    [Header("Difficulty")]
    [SerializeField] private float tempsPhase12;
    [SerializeField] private float tempsPhase23;
    [SerializeField] private float tempsPhase34;
    [SerializeField] private float vitesseEmojisPhase1;
    [SerializeField] private float vitesseEmojisPhase2;
    [SerializeField] private float vitesseEmojisPhase3;
    [SerializeField] private float vitesseEmojisPhase4;
    public float currentspeed;
    [SerializeField] private float vitesseApparition1;
    [SerializeField] private float vitesseApparition2;
    [SerializeField] private float vitesseApparition3;
    [SerializeField] private float vitesseApparition4;
    private float temps;
    private int phase = 1;
    // Start is called before the first frame update
    // Update is called once per frame
    private void Start()
    {
        currentspeed = vitesseEmojisPhase1;
        gameObject.GetComponent<T2EnnemyGenerator1>().IntervalleEntre2 = vitesseApparition1;
        temps = tempsPhase12;
        phase = 1;
    }
    void Update()
    {
        if(temps > 0)
        {
            temps -= Time.deltaTime;
        }
        else
        {
            phase++;
            switch (phase)
            {
                case 2:
                    currentspeed = vitesseEmojisPhase2;
                    gameObject.GetComponent<T2EnnemyGenerator1>().IntervalleEntre2 = vitesseApparition2;
                    temps = tempsPhase23;
                    break;
                case 3:
                    currentspeed = vitesseEmojisPhase3;
                    gameObject.GetComponent<T2EnnemyGenerator1>().IntervalleEntre2 = vitesseApparition3;
                    temps = tempsPhase34;
                    break;
                case 4:
                    currentspeed = vitesseEmojisPhase4;
                    gameObject.GetComponent<T2EnnemyGenerator1>().IntervalleEntre2 = vitesseApparition4;
                    break;
            }
           
        }
        
    }
}
