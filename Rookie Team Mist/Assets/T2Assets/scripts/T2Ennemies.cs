using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2Ennemies : MonoBehaviour
{
    [SerializeField] private float wait;
    public GameObject Manager;
    public float speed;
    private void Start()
    {
        Manager = GameObject.Find("Ennemy_Generator");
        speed = Manager.GetComponent<T2DifficultyManagement>().currentspeed;
        Destroy(gameObject,10);
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
        }
    }
    
}
