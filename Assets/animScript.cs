using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animScript : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // si le joueur tape la touche k
        if (Input.GetKey("k"))
        {
            // alors mettre le boolean isKick a true
            animator.SetBool("isKick", true);
        }
        if (!Input.GetKey("k"))
        {
            // alors mettre le boolean isKick a true
            animator.SetBool("isKick", false);
        }
    }
}
