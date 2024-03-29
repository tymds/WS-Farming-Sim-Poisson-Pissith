using System.Collections;
using UnityEngine;

public class SeedPlanting : MonoBehaviour
{
    private SeedData _seedDataPlant;

    private float _seedGrowthSpeed;
    private int _seedSell;

    [field:SerializeField]
    private GameObject _patch;

    public void OnPlant()
    {
        StartCoroutine(PlantMode());
    }

    private void Start()
    {
        _patch = GetComponent<GameObject>();
        _seedGrowthSpeed = _seedDataPlant.GrowthSpeed;
        _seedSell = _seedDataPlant.Sell;
    }

    private IEnumerator PlantMode()
    {
        yield return null;
    }
}
