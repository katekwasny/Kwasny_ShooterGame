using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixRotation : MonoBehaviour
{
    public Transform child;

    void Update()
    {
        child.transform.rotation = Quaternion.Euler(90.0f, gameObject.transform.rotation.y * -1.0f, 0.0f );
    }

}
