using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var height = Camera.main.orthographicSize * 2f;
        var width = height * Screen.width / Screen.height;
        if (gameObject.name == "background")
        {
            transform.localScale = new Vector3(width, height, 0);
        }
        else
        {
            transform.localScale = new Vector3(width + 3f, 5, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
