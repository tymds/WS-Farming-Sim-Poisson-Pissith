using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SeedShopDisplay : MonoBehaviour
{
    [SerializeField]
    private SeedData _seedDataInfo;

    [SerializeField]
    private TextMeshProUGUI _seedName;

    [SerializeField]
    private TextMeshProUGUI _seedDescription;

    [SerializeField]
    private TextMeshProUGUI _seedPrice;

    [SerializeField]
    private TextMeshProUGUI _seedSell;

    [SerializeField]
    private Image _seedShopImage;

    [SerializeField]
    private Image _seedSprite;

    [SerializeField]
    private Color _seedColor;

    private void Start()
    {
        _seedName.text = _seedDataInfo.SeedName;
        _seedDescription.text = _seedDataInfo.Description;

        _seedPrice.text = _seedDataInfo.Price.ToString();
        _seedSell.text = _seedDataInfo.Sell.ToString();

        _seedShopImage.sprite = _seedDataInfo.SpriteSeedShop;
        _seedSprite.sprite = _seedDataInfo.SpriteSeed;

        _seedColor = _seedDataInfo.SeedColor;
    }
}
