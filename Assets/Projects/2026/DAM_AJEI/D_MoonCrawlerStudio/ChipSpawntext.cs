using Autohand;
using EntilandVR.DosCinco.DAM_AJEI.G_MoonCrawlerStudio;
using System;
using UnityEngine;

public class ChipSpawntext : MonoBehaviour
{
    public TMPro.TextMeshPro text;
    public PhysicsGadgetHingeAngleReader sliderReader;
    public BetController betController;

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

            sliderValue = sliderValue * 50;
            // Sumar o restar directamente (puede ser negativo)
            value += sliderValue;

            // Limitar el total entre 0 y los puntos disponibles
            value = Mathf.Clamp(value, 0, betController.puntosTotales);

            // Mostrar el valor
            text.text = Mathf.Round(value).ToString();
        }
    }

    public void ResetValue()
    {
        value = 0f;
        text.text = "0";
    }
}