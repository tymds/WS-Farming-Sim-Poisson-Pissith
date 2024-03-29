using UnityEngine;

[CreateAssetMenu(fileName = "Seeds", menuName = "SeedInfo", order = 0)]

public class SeedData : ScriptableObject
{
    [field:SerializeField]
    public string SeedName { get; private set; }

    [field: SerializeField]
    public string Description { get; private set; }

    [field: SerializeField]
    public int Price { get; private set; }

    [field: SerializeField]
    public int Sell { get; private set; }

    [field: SerializeField]
    public int GrowthSpeed { get; private set; }

    [field: SerializeField]
    public Sprite SpriteSeed { get; private set; }

    [field: SerializeField]
    public Sprite SpriteSeedShop { get; private set; }

    [field: SerializeField]
    public Color SeedColor { get; private set; }
}
