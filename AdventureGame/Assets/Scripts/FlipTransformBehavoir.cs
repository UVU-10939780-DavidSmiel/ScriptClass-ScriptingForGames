using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipTransformBehavoir : MonoBehaviour
{
   public KeyCode Key1 = KeyCode.RightArrow, Key2 = KeyCode.LeftArrow;
   public float direction1 = 0, direction2 = 180;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(Key1)){
            transform.rotation = Quaternion.Euler(0, direction1, 0);
        }

        if (!Input.GetKeyDown(Key2)) return;
        transform.rotation = Quaternion.Euler(0, direction2, 0);
    }
}
