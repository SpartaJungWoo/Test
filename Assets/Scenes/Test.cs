using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Vector3 Speed = new Vector3(0,0.5f, 0);

    // Update is called once per frame
    void Update()
    {
        transform.position += Speed;
    }
}

