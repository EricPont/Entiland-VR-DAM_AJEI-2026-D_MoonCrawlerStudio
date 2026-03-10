using Autohand;
using System;
using UnityEngine;

public class ChipSpawntext : MonoBehaviour
{
    public TMPro.TextMeshPro text;
    public PhysicsGadgetHingeAngleReader sliderReader;

    float value = 0f;
    float timer = 0f;
    float interval = 0.3f;

    public float LastValue => value;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            timer = 0f;

            float sliderValue = sliderReader.GetValue();

            value += sliderValue;

            // evitar que sea menor que 0
            if (value < 0)
                value = 0;

            text.text = Math.Round(value, 2).ToString();
        }
    }
}