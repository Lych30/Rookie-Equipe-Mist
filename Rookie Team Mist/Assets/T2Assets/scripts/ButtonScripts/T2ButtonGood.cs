using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2ButtonGood : MonoBehaviour
{
    public void Good()
    {
        Debug.Log("Good");
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().PhaseActive = true;
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().phase = 1;
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().ButtonIsPressed = true;
    }
    public void Bad()
    {
        Debug.Log("Bad");
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().PhaseActive = true;
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().phase = 1;
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().ButtonIsPressed = true;

    }
    public void Neutral()
    {
        Debug.Log("Neutral");
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().PhaseActive = true;
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().phase = 1;
        GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().ButtonIsPressed = true;
    }
}
