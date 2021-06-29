using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballon_Controller : MonoBehaviour
{
    public float vitesse;
    public Rigidbody propphys;
    public float jumpheight;
    private Vector3 direction;
    float x = (float)-5.8, y = (float)1.7, z = 0, z_trans = 0, z_t = 0; // position de ballon (x ,y, z)



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("k"))
        {
            z_t = (float)0.0225;
        }
        z_trans += z_t;
        if (z_trans >= 1)
            z = 10;
      
        direction = new Vector3(Input.GetAxis("Horizontal"), 0, z);
    }
    private void FixedUpdate()
    {
        propphys.MovePosition(transform.position + direction * vitesse * Time.deltaTime);
    }
}
