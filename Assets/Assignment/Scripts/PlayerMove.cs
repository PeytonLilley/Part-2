using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;
    Vector2 newPosition;
    Vector2 movement;
    public float speed = 5f;
    public float score = 0;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        animator.SetFloat("Walking", movement.magnitude);
        if (rb.position == newPosition)
        {
            //    speed = 0;
        }
    }

    void FixedUpdate()
    {
        movement = newPosition - (Vector2)transform.position;
        if (movement.magnitude < 0.1)
        {
            movement = Vector2.zero;
        }
        rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D()
    {
        animator.SetTrigger("Interact");
        gameObject.SendMessage("Score");
    }

    void Score()
    {
        score = score + 1;
    }
}
