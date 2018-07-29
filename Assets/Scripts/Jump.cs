using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("space");
            transform.Translate(Vector3.up * 100 * Time.deltaTime, Space.World);
        }

    }
}
