using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigAsteroid : MonoBehaviour
{
    public GameObject medAsteroid;
    public GameObject smallAsteroid;
    public GameObject explosion;

    public int size = 3;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        float xforce = Random.Range(-50f, 50f);
        float yforce = Random.Range(-50f, 50f);
        rb.AddForce(new Vector2(xforce, yforce));
        
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Laser"))
        {
            if (size == 3)
            {
                GameObject aster1 = Instantiate(medAsteroid, transform.position, transform.rotation);
                aster1.transform.localScale = new Vector2(transform.localScale.x * 0.75f, transform.localScale.y * 0.75f);
                aster1.GetComponent<BigAsteroid>().size = 2;
                GameObject aster2 = Instantiate(medAsteroid, transform.position, transform.rotation);
                aster2.transform.localScale = new Vector2(transform.localScale.x * 0.75f, transform.localScale.y * 0.75f);
                aster2.GetComponent<BigAsteroid>().size = 2;
            }
            else if (size == 2)
            {
                GameObject aster1 = Instantiate(medAsteroid, transform.position, transform.rotation);
                aster1.transform.localScale = new Vector2(transform.localScale.x * 0.5f, transform.localScale.y * 0.5f);
                aster1.GetComponent<BigAsteroid>().size = 1;
                GameObject aster2 = Instantiate(medAsteroid, transform.position, transform.rotation);
                aster2.transform.localScale = new Vector2(transform.localScale.x * 0.5f, transform.localScale.y * 0.5f);
                aster2.GetComponent<BigAsteroid>().size = 1;
            }
            GameObject exp = Instantiate(explosion, transform.position, transform.rotation);
            Destroy(exp, 1f);
            Destroy(collision.gameObject);
            GameController.score += 10;
        }
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
