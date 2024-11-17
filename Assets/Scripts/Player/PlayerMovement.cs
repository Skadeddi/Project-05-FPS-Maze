using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController cc;
    public Camera cam;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        cc.Move(((transform.forward * Input.GetAxisRaw("Vertical")) + (transform.right * Input.GetAxisRaw("Horizontal"))).normalized * speed * Time.deltaTime);
        cc.Move (new Vector3 (0, -1, 0) * Time.deltaTime);
        transform.eulerAngles = new Vector3(0, cam.transform.eulerAngles.y, 0);
    }
}
