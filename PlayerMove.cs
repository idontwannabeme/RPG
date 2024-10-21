using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 6.0f;
    public float _gravity = -9.8f;
    private CharacterController _charControl;

        private void Start()
        {
        _charControl = GetComponent<CharacterController>();
        if (_charControl == null)
            Debug.Log("_charControl is NULL");
        }

    private void Update()
    {
        float DeltaX = Input.GetAxis("Horizontal") * speed;
        float DeltaY = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3 (DeltaX, 0, DeltaY);
        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = _gravity;
        movement *= Time.deltaTime;

        movement = transform.TransformDirection(movement);
        _charControl.Move(movement);
    }

    
    
    
    
}

