using UnityEngine;
using UnityEngine.UI;

public class Hand : MonoBehaviour
{
    private Button _handButton;

    private CursorMode _handCursor = CursorMode.Auto;
    private Vector2 _handSpot = Vector2.zero;

    [SerializeField]
    private Texture2D _handSprite;

    public bool HandModeOn { get; set; }

    public void HandMode()
    {
        SendMessageUpwards("OnHand");
        HandModeOn = true;
        Cursor.SetCursor(_handSprite, _handSpot, _handCursor);
    }

    private void Start()
    {
        _handButton = GetComponent<Button>();
        _handButton.onClick.AddListener(HandMode);
    }
}
