using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    private Animator anim;
    bool facingRight = true;

    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        
        // using mousePosition and player's transform (on orthographic camera view)
        var delta = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        if (delta.x >= 0 && !facingRight)
        { // mouse is on right side of player
            //transform.localScale = new Vector3(1, 1, 1); // or activate look right some other way
            //facingRight = true;
            anim.SetBool("facingRight", true);

        }
        else if (delta.x < 0 && facingRight)
        { // mouse is on left side
            //transform.localScale = new Vector3(-1, 1, 1); // activate looking left
            //facingRight = false;
            anim.SetBool("facingRight", false);
        }
        
    }



   



}
