using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2Audio : MonoBehaviour
{
    AudioSource Spitfire;
    AudioSource Ascenseur;

    bool APlay;

    void Start()
    {
        Spitfire = GetComponent<AudioSource>(); 
        Ascenseur = GetComponent<AudioSource>();
        APlay = true;
    }

    public void SetMaxAffection(bool changement)
    {
        if (APlay == true && changement == true)
        {
            Ascenseur.Stop();
            Spitfire.Play();
            APlay = false;
        }

        if (APlay == false && changement == true)
        {
            Spitfire.Stop();
            Ascenseur.Play();
            APlay = true;
        }
    }

void Update()
    {
        
    }

}
