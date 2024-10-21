using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{

    Animator anim;
   
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) anim.SetBool("attack", true);
        else if (Input.GetButtonUp("Fire1")) anim.SetBool("attack", false);
    }


}
