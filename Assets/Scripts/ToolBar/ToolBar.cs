using UnityEngine;

public class ToolBar : MonoBehaviour
{
    [field: SerializeField]
    public Trowel Trowel { get; private set; }

    [field: SerializeField]
    public WateringCan WateringCan { get; private set; }

    [field: SerializeField]
    public Hand Hand { get; private set; }

    public void OnHand()
    {
        Trowel.TrowelModeOn = false;
        WateringCan.CanModeOn = false;
    }

    public void OnWateringCan()
    {
        Hand.HandModeOn = false;
        Trowel.TrowelModeOn = false;
    }

    public void OnTrowel()
    {
        Hand.HandModeOn = false;
        WateringCan.CanModeOn = false;
    }
}
