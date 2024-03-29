using UnityEngine;

public class DragAndDropSeeds : MonoBehaviour
{
    private Collider2D _drop;
    private Vector3 _drag;

    [field: SerializeField]
    public SeedData Data { get; private set; }

    public SeedPlanting SeedPlanting { get; private set; }

    [field:SerializeField]
    public ToolBar ToolBar { get; private set; }

    private void Awake()
    {
       _drop = GetComponent<BoxCollider2D>();
       ToolBar = GetComponent<ToolBar>();
    }

    private Vector3 MousePos() // Position mouse on screen.
    {
        var mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mousePosition);
    }

    private void OnMouseDown() // Hold Mouse Button to pickup seed
    {
        _drag = transform.position - MousePos();
    }

    private void OnMouseDrag() // Hold and drag
    {
        if (ToolBar.Hand.HandModeOn == true)
        {
            transform.position = MousePos() + _drag;
        }
    }

    private void OnMouseUp() // Seed Planted on drop
    {
        _drop.enabled = false;
        var ray = Camera.main.transform.position;
        var rayMouse = MousePos() - Camera.main.transform.position;
        RaycastHit2D rayHit;
        if (rayHit = Physics2D.Raycast(ray, rayMouse))
        {
            if (rayHit.transform.tag == "Patch")
            {
                transform.position = rayHit.transform.position + new Vector3(0, 0, -0.01f); // Raycast at transform.
                SeedPlanting.SendMessageUpwards("OnPlant");
                Destroy(this.gameObject);
                Debug.Log("Ok");
            }
        }

        _drop.enabled = true;
    }
}
