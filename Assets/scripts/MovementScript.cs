using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementScript : MonoBehaviour
{
    public InputActionReference jumpButton = null;
    public InputActionReference moveAction = null;
    public CharacterController charController;
    public float jumpHeight;
    public float moveSpeed = 5.0f;
    private float gravityValue = -9.81f;

    private Vector3 playerVelocity;

    public bool jumpButtonReleased;

    void Start()
    {
        jumpButtonReleased = true;
    }

    void Update()
    {
        // Oyuncunun hareket girdisini al
        Vector2 moveInput = moveAction.action.ReadValue<Vector2>();

        // Kameran�n y�n�n� al ve yatay d�zlemde kullan
        Transform cameraTransform = Camera.main.transform;
        Vector3 forward = cameraTransform.forward;
        forward.y = 0;
        forward.Normalize();
        Vector3 right = cameraTransform.right;
        right.y = 0;
        right.Normalize();

        // Hareket vekt�r�n� kamera y�n�ne g�re ayarla
        Vector3 move = forward * moveInput.y + right * moveInput.x;
        charController.Move(move * moveSpeed * Time.deltaTime); // Hareketi uygulay�n

        // Yer�ekimi etkisini ve z�plama kontrol�n� uygula
        playerVelocity.y += gravityValue * Time.deltaTime;

        if (charController.isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        // Z�plama butonunun durumunu kontrol et
        float jumpVal = jumpButton.action.ReadValue<float>();
        if (jumpVal > 0 && jumpButtonReleased == true)
        {
            jumpButtonReleased = false;
            Jump();
        }
        else if (jumpVal == 0)
        {
            jumpButtonReleased = true;
        }

        // Dikey hareket (yer�ekimi ve z�plama) vekt�r�n� uygula
        charController.Move(playerVelocity * Time.deltaTime);

        //CheckAndJumpOverObstacles();
    }

    public void Jump()
    {
        playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
    }
}
