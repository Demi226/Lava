using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player, tEnemy;
    public float moveSpeed = 5f, damageToDeal;
    private Rigidbody2D rb;
    private Vector2 movement;
    public PlayerMovement playerMovement;

    public EnemyController enemyController;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
        
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            tEnemy.position = enemyController.listOfSpawns[Random.Range(0, 7)].position;    
            playerMovement.TakeDamage(damageToDeal);
        }
        if(collision.tag == "Weapon")
        {
            tEnemy.position = enemyController.listOfSpawns[Random.Range(0, 7)].position;
        }
    }
}
