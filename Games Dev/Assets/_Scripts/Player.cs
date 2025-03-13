using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private string _horizontalAxis = "Horizontal", _verticalAxis = "Vertical";
    [SerializeField]
    private Rigidbody2D _rb2d;

    private Vector2 _input;

    private void FixedUpdate()
    {
        _rb2d.linearVelocity = _input;
    }


    void Update()
    {
        float horizontalInput = Input.GetAxisRaw(_horizontalAxis);
        float verticalInput = Input.GetAxisRaw(_verticalAxis);
        _input = new Vector2(horizontalInput, verticalInput);
    }
}