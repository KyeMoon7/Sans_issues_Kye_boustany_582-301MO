using UnityEngine;
using UnityEngine.InputSystem; // Required for the New Input System

[RequireComponent(typeof(AudioSource))]
public class walking : MonoBehaviour
{
    [Header("Timing")]
    public float stepInterval = 0.4f;
    public float inputThreshold = 0.1f;

    private AudioSource audioSource;
    private float stepTimer;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        Vector2 moveInput = Vector2.zero;

        // Read WASD and Arrow Keys directly
        if (Keyboard.current != null)
        {
            if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) moveInput.y += 1f;
            if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) moveInput.y -= 1f;
            if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) moveInput.x -= 1f;
            if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) moveInput.x += 1f;
        }

        // Optional: Also check Gamepad left stick if connected
        if (Gamepad.current != null && moveInput == Vector2.zero)
        {
            moveInput = Gamepad.current.leftStick.ReadValue();
        }

        bool isMoving = moveInput.magnitude > inputThreshold;

        if (isMoving)
        {
            stepTimer -= Time.deltaTime;
            if (stepTimer <= 0f)
            {
                audioSource.Play();
                stepTimer = stepInterval;
            }
        }
        else
        {
            stepTimer = 0f;
        }
    }
}