using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public LayerMask doorMask;
    private Camera cam;
    private RaycastHit hit;
    private void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E!");
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 3, doorMask))
            {
                Debug.Log("Hit!");
                hit.collider.transform.parent.GetComponentInParent<Animator>().SetBool("Open", !hit.collider.transform.parent.GetComponentInParent<Animator>().GetBool("Open"));
            }
        }
    }

}
