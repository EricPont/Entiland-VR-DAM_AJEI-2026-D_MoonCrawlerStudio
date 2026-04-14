using NaughtyAttributes;
using TMPro;
using UnityEngine;

namespace EntilandVR.DosCinco.DAM_AJEI.G_MoonCrawlerStudio
{
    public class BetController : MonoBehaviour
    {
        public int puntosRojos;
        public int puntosVerdes;
        public int puntosAzules;

        public int puntosTotales;

        public TMP_Text textoRojo;
        public TMP_Text textoVerde;
        public TMP_Text textoAzul;
        public TMP_Text textoPuntosTotales;

        public GameObject loseScreen;

        private void Start()
        {
            loseScreen.SetActive(false);
        }

        public void ChangeBet(int p, string c)
        {
            switch (c)
            {
                case "Rojo":
                    puntosRojos += p;
                    textoRojo.text = puntosRojos.ToString();
                    break;

                case "Verde":
                    puntosVerdes += p;
                    textoVerde.text = puntosVerdes.ToString();
                    break;

                case "Azul":
                    puntosAzules += p;
                    textoAzul.text = puntosAzules.ToString();
                    break;

                default:
                    Debug.Log("Color desconocido");
                    break;
            }
        }

        public void ResolveBet(string colorGanador)
        {
            int recompensa = 0;

            switch (colorGanador)
            {
                case "Rojo":
                    recompensa = puntosRojos * 3;
                    break;

                case "Verde":
                    recompensa = puntosVerdes * 3;
                    break;

                case "Azul":
                    recompensa = puntosAzules * 3;
                    break;
            }

            puntosTotales += recompensa;
            textoPuntosTotales.text = puntosTotales.ToString();
            if (puntosTotales > 0)
            {
                loseScreen.SetActive(true);
            }

            // Reset apuestas
            puntosRojos = 0;
            puntosVerdes = 0;
            puntosAzules = 0;

            textoRojo.text = "0";
            textoVerde.text = "0";
            textoAzul.text = "0";
        }
    }
}