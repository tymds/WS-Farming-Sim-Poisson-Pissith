using UnityEngine;
using UnityEngine.UI;

public class ShopSeedBuy : MonoBehaviour
{
    [field:SerializeField]
    private Button _buy;

    [field:SerializeField]
    public GameObject SeedPrefab { get; private set; }

    [field:SerializeField]
    public SeedData SeedData { get; private set; }

    public ShopMain ShopMain { get; private set; }

    public void BuySeed()
    {
        if (ShopMain.ShopRessource.BankMoney >= SeedData.Price)
        {
            Debug.Log("Bought for" + SeedData.Price);
            ShopMain.ShopRessource.BankMoney -= SeedData.Price;
            ShopMain.ShopSpawner.BuySpawn();
            Debug.Log("BoughtFInal");
        }
    }

    private void Start()
    {
        _buy = GetComponent<Button>();
        _buy.onClick.AddListener(BuySeed);
        ShopMain = GetComponent<ShopMain>();
    }
}
