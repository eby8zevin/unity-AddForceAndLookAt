using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addforce : MonoBehaviour
{
	public float thrust;
    public Rigidbody rb;

    [SerializeField]
    KeyCode keyBut;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(keyBut))
        rb.AddForce(0,0,0.1f, ForceMode.Impulse);
    }
}
