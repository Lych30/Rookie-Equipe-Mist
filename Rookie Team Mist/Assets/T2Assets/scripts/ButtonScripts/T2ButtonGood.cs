using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2ButtonGood : MonoBehaviour
{
    public void Good()
    {
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().phase = 1;
        Debug.Log("Good");
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().PhaseActive = true;
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().temps = 15f;
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().ButtonIsPressed = true;
    }
    public void Bad()
    {
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().phase = 1;
        Debug.Log("Bad");
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().PhaseActive = true;
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().temps = 15f;
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().ButtonIsPressed = true;

    }
    public void Neutral()
    {
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().phase = 1;
        Debug.Log("Neutral");
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().PhaseActive = true;
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().temps = 15f;
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().ButtonIsPressed = true;
    }
}
