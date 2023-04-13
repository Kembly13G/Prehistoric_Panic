using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField]
    GameObject[] points;

    [SerializeField]
    float platformSpeed = 3;

    int pointsIndex = 0;

    void Update()
    {
        MovePlatform();
    }

    void MovePlatform()
    {
        if (points.Length == 0)
        {
            return;
        }

        if (pointsIndex < 0 || pointsIndex >= points.Length)
        {
            pointsIndex = 0;
        }

        if (Vector3.Distance(transform.position, points[pointsIndex].transform.position) < 0.1F)
        {
            pointsIndex++;

            if (pointsIndex >= points.Length)
            {
                pointsIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position,
            points[pointsIndex].transform.position, platformSpeed * Time.deltaTime);

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
