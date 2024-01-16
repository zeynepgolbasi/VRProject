//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.InputSystem;

//public class MovementScript : MonoBehaviour
//{
//    public InputActionReference jumpButton = null;
//    public InputActionReference moveAction = null; // Hareket için girdi eylemini tanýmlayýn
//    public CharacterController charController;
//    public float jumpHeight;
//    public float moveSpeed = 5.0f; // Hareket hýzýný ekleyin
//    private float gravityValue = -9.81f;

//    private Vector3 playerVelocity;

//    public bool jumpButtonReleased;

//    private bool isTouchingGround;

//    void Start()
//    {
//        jumpButtonReleased = true;
//    }

//    void Update()
//    {
//        Vector2 moveInput = moveAction.action.ReadValue<Vector2>(); // Hareket girdisini alýn
//        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y); // X ve Y girdilerini kullanarak bir Vector3 oluþturun
//        charController.Move(move * moveSpeed * Time.deltaTime); // Hareketi uygulayýn

//        playerVelocity.y += gravityValue * Time.deltaTime;
//        charController.Move(playerVelocity * Time.deltaTime);

//        if (charController.isGrounded && playerVelocity.y < 0)
//        {
//            playerVelocity.y = 0f;
//            isTouchingGround = true;
//        }

//        float jumpVal = jumpButton.action.ReadValue<float>();
//        if (jumpVal > 0 && jumpButtonReleased == true)
//        {
//            jumpButtonReleased = false;
//            Jump();
//            isTouchingGround = false;
//        }
//        else if (jumpVal == 0)
//        {
//            jumpButtonReleased = true;
//        }
//    }

//    public void Jump()
//    {
//        if (isTouchingGround == false)
//        {
//            return;
//        }
//        playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
//    }
//}

#pragma warning disable 618
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementScript : MonoBehaviour
{
    public InputActionReference jumpButton = null;
    public InputActionReference moveAction = null; // Hareket için girdi eylemini tanýmlayýn
    public CharacterController charController;
    public float jumpHeight;
    public float moveSpeed = 5.0f; // Hareket hýzýný ekleyin
    private float gravityValue = -9.81f;

    private Vector3 playerVelocity;

    public bool jumpButtonReleased;

    private bool isTouchingGround;

    void Start()
    {
        jumpButtonReleased = true;
    }
    void Update()
    {
        // Oyuncunun hareket girdisini al
        Vector2 moveInput = moveAction.action.ReadValue<Vector2>();

        // Kameranýn yönünü al ve yatay düzlemde kullan
        Transform cameraTransform = Camera.main.transform;
        Vector3 forward = cameraTransform.forward;
        forward.y = 0; // Y eksenini sýfýrla
        forward.Normalize();
        Vector3 right = cameraTransform.right;
        right.y = 0; // Y eksenini sýfýrla
        right.Normalize();

        // Hareket vektörünü kamera yönüne göre ayarla
        Vector3 move = forward * moveInput.y + right * moveInput.x;
        charController.Move(move * moveSpeed * Time.deltaTime); // Hareketi uygulayýn

        // Yerçekimi etkisini ve zýplama kontrolünü uygula
        playerVelocity.y += gravityValue * Time.deltaTime;

        if (charController.isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
            isTouchingGround = true;
        }

        // Zýplama butonunun durumunu kontrol et
        float jumpVal = jumpButton.action.ReadValue<float>();
        if (jumpVal > 0 && jumpButtonReleased == true)
        {
            jumpButtonReleased = false;
            Jump();
            isTouchingGround = false;
        }
        else if (jumpVal == 0)
        {
            jumpButtonReleased = true;
        }

        // Dikey hareket (yerçekimi ve zýplama) vektörünü uygula
        charController.Move(playerVelocity * Time.deltaTime);

        CheckAndJumpOverObstacles();
    }


    private void CheckAndJumpOverObstacles()
    {
        // Karakterin altýnda bir ray gönder
        Ray ray = new Ray(transform.position, Vector3.up);
        RaycastHit hit;

        // Ray engel ile temas etti mi kontrol et
        if (Physics.Raycast(ray, out hit, 0.1f)) // 0.1f ray uzunluðunu temsil eder, uygun bir deðer ayarlayýn
        {
            // Eðer engel varsa, zýpla
            Jump();
        }
    }
    public void Jump()
    {
        if (isTouchingGround == false)
        {
            return;
        }
        playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
    }
}

#pragma warning restore 618

