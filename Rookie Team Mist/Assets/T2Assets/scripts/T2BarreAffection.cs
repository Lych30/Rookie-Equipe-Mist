using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class T2BarreAffection : MonoBehaviour
{

    public Slider slider;

    public Gradient gradient;

    public Image fill;

    public void SetMaxAffection(int affection)
    {
        slider.maxValue = affection;
        slider.value = affection;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetAffection(int affection)
    {
        slider.value = affection;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    private void Update()
    {

    }
}