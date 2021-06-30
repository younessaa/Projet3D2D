using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animScript : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        // 
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // forwardPressed prend l'etat de la touche k, true si la touche est enfonce et false sinon
        bool forwardPressed = Input.GetKey("k");
        // si le joueur tape la touche k
        if (forwardPressed)
        {
            // alors mettre le boolean isKick a true
            animator.SetBool("isKick", true);
        }
        if (!forwardPressed)
        {
            // alors mettre le boolean isKick a false
            animator.SetBool("isKick", false);
        }
    }
}
