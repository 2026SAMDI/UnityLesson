using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController _cc;
    [SerializeField] private float speed = 5f;
    [SerializeField] private Transform playerCamera;
    private float xRotation = 0f;

    private Vector2 moveInput;

    public void OnMove(InputAction.CallbackContext ctx)
    {
        moveInput = ctx.ReadValue<Vector2>();
    }

    void Update()
    {
        Vector3 move = transform.right * moveInput.x + transform.forward * moveInput.y;
        _cc.Move(move * speed * Time.deltaTime);
    }

    public void OnLook(InputAction.CallbackContext ctx)
    {
        Vector2 lookInput = ctx.ReadValue<Vector2>();
        float mouseX = lookInput.x * 0.1f;
        float mouseY = lookInput.y * 0.1f;

        transform.Rotate(Vector3.up * mouseX);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        playerCamera.localRotation = Quaternion.Euler(xRotation, 0, 0);
    }
}