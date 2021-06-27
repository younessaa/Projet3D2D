using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballon_Controller : MonoBehaviour
{
    public float vitesse;
    public Rigidbody propphys;
    public float jumpheight;
    private Vector3 direction;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
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
