using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Transform[] views; // tableaux des différents views
    public float transitionSpeed; // vitesse de transition
    Transform currentView; // vue actuelle

    // Start is called before the first frame update
    void Start()
    {
        // initialisation de currentView par la première vue
        currentView = views[0];
    }

    // Update is called once per frame
    void Update()
    {
        // si la button 1 taper appliquer la premiere vue
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentView = views[0];
        }
        // si la button 2 taper appliquer la 2eme vue
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentView = views[1];
        }
        // si la button 3 taper appliquer la 3eme vue
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentView = views[2];
        }
    }

    void LateUpdate()
    {
        // transformation du la position de caméra
        // Translation de caméra
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);

        // Rotation de caméra
        Vector3 currentAngle = new Vector3 (
           Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
           Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
           Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed)
        );
        transform.eulerAngles = currentAngle;
    }
}
