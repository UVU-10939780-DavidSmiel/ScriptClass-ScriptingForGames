using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    private void Start()
    {
                rb = GetComponent<Rigidbody>();
                rb.AddForce(Vector3.right * 500);
    }

}