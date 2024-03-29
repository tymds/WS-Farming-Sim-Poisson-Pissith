using UnityEngine;

public class SeedShopSpawner : MonoBehaviour
{
    [field: SerializeField]
    private BoxCollider2D _boxCollider;

    [field: SerializeField]

    private ShopMain _shopMain;

    private Vector2 cubeCollider;
    private Vector2 colliderCenter;

    public GameObject FallSeed { get; private set; }

    public void BuySpawn()
    {
        Instantiate(FallSeed, SpawnSeed(), Quaternion.identity);
    }

    private void Awake()
    {
        Transform collidertransform = _boxCollider.GetComponent<Transform>();
        colliderCenter = collidertransform.position;

        cubeCollider.x = collidertransform.localScale.x * _boxCollider.size.x;
        cubeCollider.y = collidertransform.localScale.y * _boxCollider.size.y;
    }

    private Vector2 SpawnSeed()
    {
        Vector2 seedSpawnSocket = new Vector2(Random.Range(-cubeCollider.x / 2, cubeCollider.x / 2), Random.Range(-cubeCollider.y / 2, cubeCollider.y / 2));
        return colliderCenter + seedSpawnSocket;
    }
}
