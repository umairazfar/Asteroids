using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float thrust;
    public float turn_thrust;
    public Rigidbody2D rb2D;

    private float turnInput;
    private float thrustInput;

    public GameObject laser;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject temp = Instantiate(laser, rb2D.transform.position, rb2D.transform.rotation);
            temp.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * 500);
            Destroy(temp, 2f);
        }

        thrustInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject exp = Instantiate(explosion, transform.position, transform.rotation);
        Destroy(exp, 1f);
        Destroy(gameObject);
        GameController gc = FindObjectOfType<GameController>();
        gc.ActivateRestartMenu();
        
    }
    private void FixedUpdate()
    {
        
        rb2D.AddRelativeForce(Vector2.up * thrustInput * thrust);
        rb2D.AddTorque(-turnInput);
    }
}
