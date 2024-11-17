using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlightPrefab, armPoint;
    private Animator flashlightAnimator;
    private GameObject outArms;
    public bool fout = true;

    // Start is called before the first frame update
    void Start()
    {
        outArms = armPoint.transform.GetChild(0).gameObject;
        flashlightAnimator = outArms.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            if (fout)
            {
                flashlightAnimator.SetTrigger("Exit");
                Destroy(outArms, 0.5f);
                fout = false;
            }
            else
            {
                outArms = Instantiate(flashlightPrefab, armPoint.transform);
                flashlightAnimator = outArms.GetComponent<Animator>();
                fout = true;
            }
        }
    }
}
