using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageController : MonoBehaviour
{
    [SerializeField]
    float lifeTime = 1.5F;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject, lifeTime);
        }
    }
}
