using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    private Animator myAnimator;

    void Start()
    {
        myAnimator = GetComponent<Animator>();

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myAnimator.SetTrigger("jump");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAnimator.SetTrigger("run"); 
        }

    }

}
