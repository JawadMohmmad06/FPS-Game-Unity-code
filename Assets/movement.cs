using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Vector2 turn;
    public float speed = 20;
    public float sensitivity = 1000;
    private Vector3 initialPosition;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        turn = new Vector2(0, 0); // Set the initial turn values to zero.
        transform.localRotation = Quaternion.LookRotation(transform.position, Vector3.forward); // Set initial rotation to look forward.

        // Store the initial position of the player when the game starts in play mode.
        initialPosition = transform.position;
    }

    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, 3f, transform.position.z);

  
    }

    // Function to reset the player's position to the initial position in the Unity Editor.
    public void ResetToInitialPosition()
    {
        transform.position = initialPosition;
    }

}