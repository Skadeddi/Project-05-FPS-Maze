using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomEnemy : MonoBehaviour
{
    private NavMeshAgent nme;
    private bool waiting;
    // Start is called before the first frame update
    void Start()
    {
        nme = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(nme.remainingDistance < 0.1f || !nme.hasPath || !waiting)
        {
            StartCoroutine(NewPoint());
        }
    }

    private IEnumerator NewPoint()
    {
        waiting = true;
        yield return new WaitForSeconds(1);
        waiting = false;
        nme.SetDestination(transform.position + Random.insideUnitSphere * 3);
    }
}
