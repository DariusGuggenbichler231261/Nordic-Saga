using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

     
    
    [SerializeField] float playerSpeed;
    //[SerializeField] Transform playerCamera;
    [SerializeField] Animator playerAnimator;

    private Rigidbody playerRigidbody;
    private Vector2 moveInput;
    private Vector3 playerMoveDirection;

    public int GameplayMovementPerformed { get; private set; }

    private void Awake() {
        playerRigidbody = GetComponent<Rigidbody>();
    }


    public void OnMoveInput(InputAction.CallbackContext incomingInput)
    {
        if (incomingInput.performed)
        {
            moveInput = incomingInput.ReadValue<Vector2>();
            playerAnimator.SetBool("isMoving", true);

            moveInput *= -1;
        }
        else if (incomingInput.canceled)
        {
            moveInput = Vector2.zero;
            playerAnimator.SetBool("isMoving", false);
        }
    }

    private void FixedUpdate() {
       // playerCamera.eulerAngles = new Vector3(0,playerCamera.eulerAngles.y, playerCamera.eulerAngles.z);
        //playerMoveDirection = (playerCamera.forward * moveInput.y + playerCamera.right * moveInput.x) * playerSpeed * Time.fixedDeltaTime;

        //playerRigidbody.linearVelocity = new Vector3(playerMoveDirection.x, playerRigidbody.linearVelocity.y, playerMoveDirection.z);
        playerRigidbody.linearVelocity = new Vector3(moveInput.x, playerRigidbody.linearVelocity.y, moveInput.y);

        //if (moveInput != Vector2.zero)
        //{

            //transform.forward = playerMoveDirection;
        //}  
        Debug.Log($"[Player]FixedUpdate: moveInput={moveInput}");  
        }
}
