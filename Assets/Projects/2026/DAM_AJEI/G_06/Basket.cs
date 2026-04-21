using UnityEngine;


namespace EntilandVR.DosCinco.DAM_AJEI.D_MoonCrawlerStudio
{
    public class Basket : MonoBehaviour
    {
        public enum ColorApuesta
        {
            Rojo,
            Verde,
            Azul,
            Amarillo,
            Vegeta
        }
        public G_MoonCrawlerStudio.BetController betController;
        public ColorApuesta color;

        private void OnTriggerEnter(Collider other)
        {

            if (other.CompareTag("Pickable"))
            {
                OnPickableCollected(other.gameObject);

                Destroy(other.gameObject);
            }

        }

        private void OnPickableCollected(GameObject collectedObject)
        {
            BagChips bagchips = collectedObject.GetComponent<BagChips>();
            Debug.Log("acertaste ");
            string colorString = color.ToString();
            betController.ChangeBet(bagchips.value, colorString);
            // TODO: Aquí pones tu lógica
            // Ejemplo: sumar puntos, reproducir sonido, etc.
        }
    }
}
    
