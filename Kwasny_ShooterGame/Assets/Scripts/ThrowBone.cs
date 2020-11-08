using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBone : MonoBehaviour
{
    public string FireAxis = "Fire1";
    public float ReloadDelay = 0.3f;
    public bool CanFire = true;
    public bool MouseLook = true;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //firing turret
        if (Input.GetButtonDown(FireAxis) && CanFire)
        {
          AmmoManager.SpawnAmmo(transform.position, transform.rotation);           
        }
    }

    private void FixedUpdate()
    {
        if (MouseLook)
        {
            Vector3 MousePosWorld = Camera.main.ScreenToWorldPoint(
                new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.0f));

            MousePosWorld = new Vector3(MousePosWorld.x, 0.0f, MousePosWorld.z);
            Vector3 LookDirection = MousePosWorld - transform.position;
            transform.localRotation = Quaternion.LookRotation(LookDirection.normalized, Vector3.up);
        }
    }
}
