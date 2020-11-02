using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2Ennemies : MonoBehaviour
{
    [SerializeField] private float speed;
    void Update()
    {
        transform.Translate(0, Time.deltaTime * speed, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
