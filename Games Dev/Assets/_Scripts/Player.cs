using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private string _horizontalAxis = "Horizontal", _verticalAxis = "Vertical";
    [SerializeField]
    private Rigidbody2D _rb2d;

    private Vector2 _input;

    [SerializeField]
    private float _speed = 3f;

    private void FixedUpdate()
    {
        _rb2d.linearVelocity = _input * _speed;
    }


    void Update()
    {
        float horizontalInput = Input.GetAxisRaw(_horizontalAxis);
        float verticalInput = Input.GetAxisRaw(_verticalAxis);
        _input = new Vector2(horizontalInput, verticalInput);
        _input.Normalize();
    }
}