using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FireController : MonoBehaviour
{
    private NavMeshAgent navAgent;
    public Transform[] waypoints;
    int waypointIndex;
    public float countdownTime = 8f;
    Vector3 target;

    void Start()
    {       
       navAgent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }
    void Update()
    {
        if(Vector3.Distance(transform.position, target) < 1)
        {
            IterateWaypointIndex();
            UpdateDestination();
        }
    }

    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        navAgent.SetDestination(target);
    }

    void IterateWaypointIndex()
    {
        waypointIndex++;
        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
    }
}
