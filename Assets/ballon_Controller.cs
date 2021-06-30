using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballon_Controller : MonoBehaviour
{
    public float vitesse;
    public Rigidbody propphys;
    public float jumpheight;
    private Vector3 direction;
    float z = 0, z_trans = 0, z_t = 0; // position de ballon (x ,y, z)



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("k"))
        {
            z_t = (float)0.08;
        }
        z_trans += z_t;
        if (z_trans >= 1)
            z = 10;
      
        direction = new Vector3(0, 0, z);
        if (Input.GetButtonDown("Jump"))
        {
            propphys.AddForce(Vector3.up * jumpheight, ForceMode.VelocityChange);

        }
    }
    private void FixedUpdate()
    {
        propphys.MovePosition(transform.position + direction * vitesse * Time.deltaTime);
    }
}
