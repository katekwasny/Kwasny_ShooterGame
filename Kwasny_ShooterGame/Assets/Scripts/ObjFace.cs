using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjFace : MonoBehaviour
{
    public Transform ObjToFollow = null;
    public bool FollowPlayer = false;

    void Awake()
    {
        if (!FollowPlayer)
            return;

        GameObject PlayerObj = GameObject.FindGameObjectWithTag("Player");

        if (PlayerObj != null)
            ObjToFollow = PlayerObj.transform;
    }

    void Update()
    {
        if (ObjToFollow == null)
            return;

        Vector3 DirToObject = ObjToFollow.position - transform.position;

        if(DirToObject != Vector3.zero)
        {
            transform.localRotation = Quaternion.LookRotation(DirToObject.normalized, Vector3.up);
        }
    }
}
