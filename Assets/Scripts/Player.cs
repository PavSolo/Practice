using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed=1f;
     


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float moveright = Input.GetAxis("Horizontal");
        float moveup = Input.GetAxis("Vertical");

        transform.position += new Vector3(moveright, 0, 0)*speed*Time.deltaTime;
        transform.position += new Vector3(0, moveup, 0) * speed * Time.deltaTime;



    }
}
