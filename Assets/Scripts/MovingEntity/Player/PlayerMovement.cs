using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D body;
    private BoxCollider2D boxCollider;

    private void Awake()
    {
        body = GetComponentInParent<Rigidbody2D>();
        boxCollider = GetComponentInParent<BoxCollider2D>();
    }

    private void Update()
    {
        DetectKey();
    }

    private void DetectKey()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Debug.Log(horizontalInput);
        float horizontalVelocity = horizontalInput * MEPhysics.instance.walkSpeed;

        body.velocity = new Vector2(horizontalVelocity, 0);

    }
}
