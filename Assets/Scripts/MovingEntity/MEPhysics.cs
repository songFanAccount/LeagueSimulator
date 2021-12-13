using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MEPhysics : MonoBehaviour
{
    public static MEPhysics instance;

    [Header("Platform")]
    [SerializeField] public LayerMask platformLayer;

    [Header("Stats")]
    [SerializeField] public float walkSpeed;

    private Rigidbody2D body;
    private BoxCollider2D boxCollider;

    private void Awake()
    {
        instance = this;
        body = GetComponentInParent<Rigidbody2D>();
        boxCollider = GetComponentInParent<BoxCollider2D>();
    }

    public bool onPlatform()
    {
        RaycastHit2D raycast = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, platformLayer);
        return raycast.collider != null;  
    }
}
