using UnityEngine;
using UnityEngine.UI;

public class Trowel : MonoBehaviour
{
    private Button _trowelButton;

    [SerializeField]
    private Texture2D _trowelSprite;

    private CursorMode _trowelCursor = CursorMode.Auto;
    private Vector2 _trowelSpot = Vector2.zero;

    public bool TrowelModeOn { get; set; }

    public void TrowelMode()
    {
        SendMessageUpwards("OnTrowel");
        TrowelModeOn = true;
        Cursor.SetCursor(_trowelSprite, _trowelSpot, _trowelCursor);
    }

    private void Start()
    {
        _trowelButton = GetComponent<Button>();
        _trowelButton.onClick.AddListener(TrowelMode);
    }
}
