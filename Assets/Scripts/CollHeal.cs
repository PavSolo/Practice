using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollHeal : MonoBehaviour
{
    public float collheal = 10f;
    public string colltag;
   // public Transform player;
    //public GameObject hb;
     

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == colltag)
        {

            HealthBar health = collision.gameObject.GetComponent<HealthBar>();

            if (health != null)
            {
                health.Heal(collheal);
                Destroy(gameObject);
            }
            Destroy(gameObject);
            
        }
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if ((player.position.x==transform.position.x)&&(player.position.y == transform.position.y)) {
        //}
    }
}
