using TMPro;
using UnityEngine;

public class MoneyRessource : MonoBehaviour
{
    [field: SerializeField]
    private TextMeshProUGUI _moneyCounter;

    [SerializeField]
    private int _money = 100;

    public int BankMoney { get; set; }

    private void Update()
    {
        GetComponent<TextMeshProUGUI>();
        BankMoney = BankMoney + _money;
        _moneyCounter.text = BankMoney.ToString();
    }
}
