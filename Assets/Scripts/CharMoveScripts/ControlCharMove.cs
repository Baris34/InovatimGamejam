using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCharMove : MonoBehaviour
{
    public float speed = 5;
    public bool isJumping;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        x *= speed * Time.deltaTime;
        z *= speed * Time.deltaTime;

        transform.Translate(x, 0, z);



        if (Input.GetButtonDown("Jump")&& !isJumping)
        {
            rb.AddForce(new Vector3(0, 5,0), ForceMode.Impulse);
            isJumping = true;
        }
        

    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("Platform"))
        {
            isJumping = false;
        }
    }


}
