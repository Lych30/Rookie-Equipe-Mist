using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class T2Degat : MonoBehaviour
{
    public int maxAffection = 100;
    public int affection;
    public T2BarreAffection BarreAffection;

    private void Start()
    {
        BarreAffection.SetMaxAffection(maxAffection);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("T2MauvaisSmiley"))
        {
            Takedmg(20);
        }
        if (collision.gameObject.CompareTag("T2BonSmiley"))
        {
            Soin(20);
        }
    }

    public void Soin(int heal)
    {
        affection += heal;
        BarreAffection.SetAffection(affection);
        if (affection >= maxAffection)
            affection = maxAffection;
    }

    public void Takedmg(int dmg)
    {
        affection -= dmg;
        BarreAffection.SetAffection(affection);
    }

    void Die()
    {
        SceneManager.LoadScene("GameOver");
    }

    private void Update()
    {

    }
}
