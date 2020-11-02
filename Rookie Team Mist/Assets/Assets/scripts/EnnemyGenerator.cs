using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float IntervalleEntre2;
    private float TempsRestant;
    private int rand;
    private void Start()
    {
        TempsRestant = IntervalleEntre2;
    }
    // Update is called once per frame
    void Update()
    {
        if(TempsRestant > 0)
        {
            TempsRestant -= Time.deltaTime;
        }
        else
        {
            rand = Random.Range(1, 7);
            switch (rand)
            {
                case 1:
                    Debug.Log("1");
                    break;
                case 2:
                    Debug.Log("2");
                    break;
                case 3:
                    Debug.Log("3");
                    break;
                case 4:
                    Debug.Log("4");
                    break;
                case 5:
                    Debug.Log("5");
                    break;
                case 6:
                    Debug.Log("6");
                    break;
                default:
                    break;
            }
            TempsRestant = IntervalleEntre2;
        }
    }
}
