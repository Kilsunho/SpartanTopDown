using System;
using UnityEngine;
using UnityEngine.Rendering;

public class TopDownMovement : MonoBehaviour
{
    private TopDownController controller;
    private Rigidbody2D movementRigidbody;


    private Vector2 movementvector = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        movementvector = vector;
    }

    private void FixedUpdate() // 물리업데이트 관련시 실행
    {
        ApplyMovement(movementvector);
    }

    private void ApplyMovement(Vector2 vector)
    {
        vector = vector * 5;
        movementRigidbody.velocity = vector;
    }
}