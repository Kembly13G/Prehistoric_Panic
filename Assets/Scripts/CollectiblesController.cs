using System;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class CollectiblesController : MonoBehaviour
{
    [SerializeField]
    float collectible = 1;

    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            GemsController controller = other.GetComponent<GemsController>();
            controller.ObtainedCollectibles(collectible);
            Destroy(gameObject);
        }
    }
}
