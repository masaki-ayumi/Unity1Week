using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    //private bool isJump = false;
    private Rigidbody rb;   //rigidbody

    [SerializeField]
    public int jumpPower = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    void Jump()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.AddForce(transform.up * jumpPower, ForceMode.Impulse);
            rb.AddForce(Vector3.right, ForceMode.Impulse);
        }
    }
}
