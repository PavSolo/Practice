using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Rigidbody2D physic;
    public Transform player;
    public float speed;
    public float triggDistance;
    public GameObject restartButton;
    public void Hunting()
    {
        if ((player.position.x < transform.position.x)&&(player.position.y<transform.position.y))
        {
            physic.velocity = new Vector2(-speed, -speed);
        }
        if ((player.position.x > transform.position.x)&&(player.position.y > transform.position.y))
        {
            physic.velocity = new Vector2(speed, speed);
        }
        if ((player.position.x > transform.position.x)&&(player.position.y < transform.position.y))
        {
            physic.velocity = new Vector2(speed, -speed);
        }
        if ((player.position.x < transform.position.x)&&(player.position.y > transform.position.y))
        {
            physic.velocity = new Vector2( -speed,speed);
        }

    }
    void Start()
    {
        physic = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);
        if (distToPlayer < triggDistance)
        {
            Hunting();
        }
        if (distToPlayer <= 1)
        {
            restartButton.SetActive(true);
            
        }

    }
}
