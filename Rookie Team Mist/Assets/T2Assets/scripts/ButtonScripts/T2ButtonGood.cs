using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2ButtonGood : MonoBehaviour
{
    public void Good()
    {
        
        switch (gameObject.name)
        {
            case "Theme1_Good1(Clone)":
                Salade();
                break;
            case "Theme1_Good2(Clone)":
                Citron();
                break;
            case "Theme2_Good1(Clone)":
                Sport();
                break;
            case "Theme2_Good2(Clone)":
                Théatre();
                break;
            case "Theme3_Good1(Clone)":
                Good1();
                break;
            case "Theme3_Good2(Clone)":
                Good2();
                break;
        }
        Debug.Log("Good");
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().PhaseActive = true;
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().ButtonIsPressed = true;
        Manager.GetComponent<T2DifficultyManagement>().currentspeed = 5 * GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().MultiplicateurSpeed;
    }
    public void Bad()
    {
        switch (gameObject.name)
        {
            case "Theme1_Bad1(Clone)":
                Burger();
                break;
            case "Theme1_Bad2(Clone)":
                Soda();
                break;
            case "Theme2_Bad1(Clone)":
                Soirée();
                break;
            case "Theme2_Bad2(Clone)":
                Drogue();
                break;
            case "Theme3_Bad1(Clone)":
                Bad1();
                break;
            case "Theme3_Bad2(Clone)":
                Bad2();
                break;
        }
        Debug.Log("Bad");
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().PhaseActive = true;
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().ButtonIsPressed = true;
        Manager.GetComponent<T2DifficultyManagement>().currentspeed = 5 * GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().MultiplicateurSpeed;

    }
    public void Neutral()
    {
        switch (gameObject.name)
        {
            case "Theme1_Neutral1(Clone)":
                Pate();
                break;
            case "Theme1_Neutral2(Clone)":
                Sandwich();
                break;
            case "Theme2_Neutral1(Clone)":
                Modelisme();
                break;
            case "Theme2_Neutra2(Clone)":
                JV();
                break;
            case "Theme3_Neutral1(Clone)":
                Neutre1();
                break;
            case "Theme3_Neutral2(Clone)":
                Neutre2();
                break;
        }
        Debug.Log("Neutral");
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().PhaseActive = true;
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().ButtonIsPressed = true;
    }




    void Pate()
    {
        GameObject.FindGameObjectWithTag("Player").transform.localScale *= 1.2f;
        GameObject.FindGameObjectWithTag("Player").GetComponent<T2Movement>().speed += 1.2f;
    }
    void Sandwich()
    {
        GameObject.FindGameObjectWithTag("Player").transform.localScale /= 1.2f;
    }
    void Burger()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<T2Movement>().speed -= 1.2f;
    }
    void Soda()
    {
        GameObject.FindGameObjectWithTag("Player").transform.localScale *= 1.1f;
    }
    void Salade()
    {
        GameObject.FindGameObjectWithTag("Player").transform.localScale *= 0.8f;
    }
    void Citron()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<T2Movement>().speed += 1.2f;
    }
    void Modelisme()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<T2Movement>().speed *= 1.2f;
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().MultiplicateurSpeed += 1.2f;
    }
    void JV()
    {
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().MultiplicateurSpeed -= 1.2f;
        GameObject.FindGameObjectWithTag("Player").GetComponent<T2Movement>().speed /= 1.2f;
    }
    void Soirée()
    {
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().MultiplicateurApparition += 0.1f;
    }
    void Drogue()
    {
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().MultiplicateurSpeed -= 1.2f;
    }
    void Sport()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<T2Movement>().speed *= 1.2f;

    }
    void Théatre()
    {
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().MultiplicateurSpeed += 1.2f;
    }
    void Neutre1()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<T2Movement>().speed /= 1.2f;
    }
    void Neutre2()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<T2Movement>().speed *= 1.2f;
    }
    void Bad1()
    {
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().MultiplicateurSpeed -= 1.2f;
    }
    void Bad2()
    {
        GameObject.FindGameObjectWithTag("Player").transform.localScale *= 0.9f;
    }
    void Good1()
    {
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().MultiplicateurApparition -= 0.1f;
    }
    void Good2()
    {
        GameObject.FindGameObjectWithTag("Player").transform.localScale *= 1.1f;
    }
}
