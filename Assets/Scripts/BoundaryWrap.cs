using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryWrap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if(rb.transform.position.x > 9.4f)
        {
            rb.transform.position = new Vector2(-9.4f, rb.transform.position.y);
        }
        if (rb.transform.position.x < -9.4f)
        {
            rb.transform.position = new Vector2(9.4f, rb.transform.position.y);
        }
        if (rb.transform.position.y > 5.4f)
        {
            rb.transform.position = new Vector2(rb.transform.position.x, -5.4f);
        }
        if (rb.transform.position.y < -5.4f)
        {
            rb.transform.position = new Vector2(rb.transform.position.x, 5.4f);
        }
    }
}
