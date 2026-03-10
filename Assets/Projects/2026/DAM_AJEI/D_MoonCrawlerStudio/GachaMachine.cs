using EntilandVR.DosCinco.DAM_AJEI.D_MoonCrawlerStudio;
using EntilandVR.DosCinco.DAM_AJEI.G_MoonCrawlerStudio;
using UnityEngine;

public class GachaMachine : MonoBehaviour
{

    public Basket.ColorApuesta color;

    [Header("Materiales")]
    public Material[] materials; // 0 Rojo, 1 Verde, 2 Azul

    private Renderer rend;

    public BetController betController;


    void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    public void PickRandomColor()
    {
        int randomIndex = Random.Range(0, System.Enum.GetValues(typeof(Basket.ColorApuesta)).Length);

        color = (Basket.ColorApuesta)randomIndex;

        ApplyMaterial();

        betController.ResolveBet(color.ToString());
    }


    public void ApplyMaterial()
    {
        if (materials.Length > (int)color)
        {
            rend.material = materials[(int)color];
        }
    }


}
