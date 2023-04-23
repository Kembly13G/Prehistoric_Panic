using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionController : MonoBehaviour
{
    [SerializeField]
    float lifeTime = 2F;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(tag);
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject, lifeTime);
        }
    }
}
