/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        //Move target game object
        var x = Mathf.PingPong(Time.time, 3);
        var p = new Vector3(0, x, 0);
        transform.position = p;


        //Rotate the target game object
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
    }
}
*/