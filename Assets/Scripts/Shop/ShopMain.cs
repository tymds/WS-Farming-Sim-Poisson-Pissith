using UnityEngine;

public class ShopMain : MonoBehaviour
{
    [field:SerializeField]
    public SeedShopSpawner ShopSpawner { get; private set; }

    [field: SerializeField]
    public SeedShopDisplay ShopDisplay { get; private set; }

    [field: SerializeField]
    public ShopSeedBuy ShopBuy { get; private set; }

    [field: SerializeField]
    public MoneyRessource ShopRessource { get; private set; }

    [field: SerializeField]
    public SeedData SeedInfo { get; private set; }
}
