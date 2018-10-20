using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePulley : MonoBehaviour {

    public PulleyScript PulleyScript;

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            // declare a Raycast hit
            RaycastHit hit;
            // define the ray as the mouse pos in the direction of the camera
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // take in the ray, and the hit, but make sure you output the hit information into the hit, and 100f is the distance to check
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                Debug.Log(hit.transform.gameObject);
                if (hit.transform == transform)
                {
                    PulleyScript.enabled = true;
                }
            }
        }

    }
}
