using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballon_Controller : MonoBehaviour
{
    public float vitesse;
    public Rigidbody propphys;
    private Vector3 direction;
    float z = 0, z_trans = 0, z_t = 0; // z position du ballon suivant oz, z_trans : le deplacement du joueur suivant (oz)



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // la touche k est taper : le joueur tirera le ballon
        if (Input.GetKey("k"))
        {
            // le joueur se deplace suivant (Oz)
            z_t = (float)0.03;
        }

        // la position du joueur suivant (Oz)
        z_trans += z_t;

        // le pied du joueur est au côté du ballon
        if (z_trans >= 1)
            z = 10;
      
        // changer la deriction du ballon
        direction = new Vector3(0, 0, z);
        
    }
    private void FixedUpdate()
    {
        propphys.MovePosition(transform.position + direction * vitesse * Time.deltaTime);
    }
}
