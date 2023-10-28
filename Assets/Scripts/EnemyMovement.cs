using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float enemySpeed = 1f;
    Rigidbody2D myRigidbody;
    BoxCollider2D myHandCollider;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        EnemyMove();
    }

    void EnemyMove()
    {
        myRigidbody.velocity = new Vector2 (enemySpeed, 0f);
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        enemySpeed = -enemySpeed;
        FlipEnemyFacing();
    }
    
    void FlipEnemyFacing()
    {
        transform.localScale = new Vector2 (-(Mathf.Sign(myRigidbody.velocity.x)), 1f);
    }
}
