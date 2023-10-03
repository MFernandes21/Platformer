using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    Animator anim;
    SpriteRenderer sr;
    public LayerMask groundLayer;
    void Start()
    {

        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        print("Start");
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Walk", false);
        anim.SetBool("Jump", false);
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            print("User pressed left"); transform.position = new Vector2(transform.position.x - (1 * Time.deltaTime), transform.position.y);
            anim.SetBool("Walk", true);
            sr.flipX = true;
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            print("User pressed right"); transform.position = new Vector2(transform.position.x + (1 * Time.deltaTime), transform.position.y);
            anim.SetBool("Walk", true);
            sr.flipX = false; 
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("Walk", false);
            anim.SetBool("Jump", true);
            rb.AddForce(new Vector3(0, 0.05f, 0), (ForceMode2D)ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("Attack");
        }
    }
}
