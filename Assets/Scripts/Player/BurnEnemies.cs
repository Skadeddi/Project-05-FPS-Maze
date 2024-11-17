using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnEnemies : MonoBehaviour
{
    private GameObject player;
    private Camera cam;
    public LayerMask enemyMask;
    private RaycastHit hit;
    private GameObject enemyCountHandler;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        enemyCountHandler = GameObject.Find("EnemyCountHandler");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Click by Adam Sandler");
            if (player.GetComponent<Flashlight>().fout && Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 10, enemyMask))
            {
                Destroy(hit.transform.gameObject);
                enemyCountHandler.GetComponent<EnemyCounter>().KillEnemy();
            }
        }
    }
}
