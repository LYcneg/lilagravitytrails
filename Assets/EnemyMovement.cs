using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float yForce;
    public float xForce;
    public float xDirection;
    public Teleport tp;

    private Rigidbody2D enemyRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(xForce, yForce);
            enemyRigidBody.AddForce(jumpForce);
        }
        if (collision.gameObject.tag == "ThrowingObject")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            tp.enemyCount --;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
