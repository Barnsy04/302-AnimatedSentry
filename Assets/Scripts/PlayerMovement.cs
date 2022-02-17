using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed = 5;

    CharacterController pawn;

    void Start()
    {
        pawn = GetComponent<CharacterController>();
    }


    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        Vector3 moveDir = transform.forward * v + transform.right * h;
        if (moveDir.sqrMagnitude > 1) moveDir.Normalize();

        pawn.SimpleMove(moveDir * walkSpeed);

    }
}
