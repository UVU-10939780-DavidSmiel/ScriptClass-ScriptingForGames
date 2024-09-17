using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorImpact : MonoBehaviour
{

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Color NewColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
   //////Public Color NewColor = color.red;

        GetComponent<Renderer>().material.color = NewColor;
    }
}
