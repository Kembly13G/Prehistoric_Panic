using System;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;


public class CollectiblesController : MonoBehaviour
{
    [SerializeField]
    float collectible = 1;

    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            ThirdPersonController controller = other.GetComponent<ThirdPersonController>();
            controller.ObtainedCollectibles(collectible);
            Destroy(gameObject);
        }
    }
}
