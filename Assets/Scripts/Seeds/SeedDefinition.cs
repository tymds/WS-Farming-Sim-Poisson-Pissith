using UnityEngine;
using UnityEngine.UI;

public class SeedDefinition : MonoBehaviour
{
    private SeedData _seedData;

    private GameObject _seedObject;

    private Image _seedSprite;

    private void Awake()
    {
        GetComponent<GameObject>();
        _seedSprite.sprite = _seedData.SpriteSeed;

    }
}
