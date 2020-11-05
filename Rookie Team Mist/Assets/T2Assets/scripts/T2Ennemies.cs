using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2Ennemies : MonoBehaviour
{
    [SerializeField] private float wait;
    public GameObject Manager;
    public float speed;
    public GameObject EnnemyHolder;
    private int result;
    private void Start()
    {
        EnnemyHolder = GameObject.Find("EnnemyHolder");
        Manager = GameObject.Find("Ennemy_Generator");
        speed = Manager.GetComponent<T2DifficultyManagement>().currentspeed;
        Destroy(gameObject,10);
        
        gameObject.transform.parent = EnnemyHolder.transform;
    }
  
    void Update()
    {
        if(wait > 0)
        {
            wait -= Time.deltaTime;
        }
        else
        {
            transform.Translate(0, Time.deltaTime * speed, 0);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            GameObject.Find("Canvas").GetComponent<T2TestButton>().InitialisationButton = false;
           
            GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().PhaseActive = false;

            GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().phase = 1;
            GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().temps = 15f; ;
            Manager.GetComponent<T2DifficultyManagement>().currentspeed = 5 * GameObject.Find("Ennemy_Generator").GetComponent<T2DifficultyManagement>().MultiplicateurSpeed;
            if (GameObject.Find("Canvas").GetComponent<T2TestButton>().manche == 4)
            {
                result = GameObject.FindGameObjectWithTag("Player").GetComponent<T2Degat>().affection;
                if (result <= 0)
                {
                    result *= 1;
                }
                else
                {
                    if (result >= 1 && result <= 49)
                    {
                        result *= 2;
                    }
                    else
                    {
                        if(result == 50)
                        {
                            result *= 3;
                        }
                        else
                        {
                            if(result > 50 && result <= 99)
                            {
                                result *= 4;
                            }
                            else
                            {
                                result *= 5;
                            }
                        }
                    }
                }
                Debug.Log(result);
            }
            foreach (Transform child in EnnemyHolder.transform)
                Destroy(child.gameObject);
        }
    }
}
