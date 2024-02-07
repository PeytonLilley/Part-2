using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5;
    float timer = 0;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 direction = new Vector2(speed * Time.deltaTime, 0);
        rb.MovePosition(rb.position + direction);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            Destroy(gameObject);
            timer = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D collision2D)
    {
        collision2D.gameObject.SendMessageUpwards("TakeDamage", 1, SendMessageOptions.DontRequireReceiver);
        Destroy(gameObject);

      
    }

}
