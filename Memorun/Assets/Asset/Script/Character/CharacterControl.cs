//https://craftgames.co/unity-3d-fps-movement/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public Animator anim;
    Rigidbody rb;
    [SerializeField] float speed;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
       
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        Vector3 moveBy = transform.right * x + transform.forward * z;
        rb.MovePosition(transform.position + moveBy.normalized * speed * Time.fixedDeltaTime);
    }

    private void Update()
    {
        

        //trigger animation
        
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("Walking", true);
        }
        else { anim.SetBool("Walking", false); }
        
    }
}
