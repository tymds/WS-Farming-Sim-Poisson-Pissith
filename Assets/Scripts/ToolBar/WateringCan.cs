using UnityEngine;
using UnityEngine.UI;

public class WateringCan : MonoBehaviour
{
    private Button _canButton;

    [SerializeField]
    private Texture2D _canSprite;

    private CursorMode _canCursor = CursorMode.Auto;
    private Vector2 _canSpot = Vector2.zero;

    public bool CanModeOn { get; set; }

    public void CanMode()
    {
        SendMessageUpwards("OnWateringCan");
        CanModeOn = true;
        Cursor.SetCursor(_canSprite, _canSpot, _canCursor);
    }

    private void Start()
    {
        _canButton = GetComponent<Button>();
        _canButton.onClick.AddListener(CanMode);
    }
}
