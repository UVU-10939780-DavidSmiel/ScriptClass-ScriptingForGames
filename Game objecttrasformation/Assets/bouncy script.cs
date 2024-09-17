using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncyscript : MonoBehaviour
{
    public float bounceForce = 3f;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
    }


}
