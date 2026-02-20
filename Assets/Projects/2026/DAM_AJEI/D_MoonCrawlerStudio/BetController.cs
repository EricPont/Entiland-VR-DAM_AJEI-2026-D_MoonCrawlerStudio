using System.Drawing;
using TMPro;
using UnityEngine;

namespace EntilandVR.DosCinco.DAM_AJEI.G_MoonCrawlerStudio
{
    public class BetController : MonoBehaviour
    {
        public int puntosRojos;
        public int puntosVerdes;
        public int puntosAzules;
        public TMP_Text textoRojo;
        public TMP_Text textoVerde;
        public TMP_Text textoAzul;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

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
    }
}

    
