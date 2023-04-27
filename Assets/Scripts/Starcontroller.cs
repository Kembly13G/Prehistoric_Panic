using System;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarController : MonoBehaviour
{
    [SerializeField]
    float collectible = 1;

    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            TotalStarController controller = other.GetComponent<TotalStarController>();
            controller.ObtainedCollectibles(collectible);
            Destroy(gameObject);
        }
    }
}
