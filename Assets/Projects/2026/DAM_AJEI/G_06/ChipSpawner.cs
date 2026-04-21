using UnityEngine;
using Autohand.Demo;
using EntilandVR.DosCinco.DAM_AJEI.D_MoonCrawlerStudio;
using EntilandVR.DosCinco.DAM_AJEI.G_MoonCrawlerStudio;

public class ChipSpawner : MonoBehaviour
{
    public GameObject chipPrefab;
    public ChipSpawntext lever;
    public BetController bCont;

    public void InitializeChip()
    {
        Vector3 spawnPos = transform.position;
        spawnPos.y = 1f; // forzar Y = 1


        GameObject chip = Instantiate(chipPrefab, spawnPos, Quaternion.identity);

        BagChips bag = chip.AddComponent<BagChips>();

        chip.tag = "Pickable"; // asignar tag


        bag.value = Mathf.RoundToInt(lever.LastValue);

        Debug.Log("Chip creada con valor: " + bag.value);

        bCont.chipBagCreated(bag.value);

    }
}