using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class fire : MonoBehaviour
{
    
    public float hideTime = 2.0f; // tiempo en segundos que el objeto se ocultará

   
   private NavMeshAgent navAgent;


  public Transform[] waypoints;
    public float speed = 5.0f;

   

    int waypointIndex;



    public float countdownTime = 6f;
    Vector3 target;
    void Start()
    {
        gameObject.SetActive(false);
        
       navAgent = GetComponent<NavMeshAgent>();
        UpdateDestination();
        Invoke("ShowObject", hideTime);
    }

    void ShowObject()
{
    gameObject.SetActive(true); // mostrar el objeto de nuevo
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
