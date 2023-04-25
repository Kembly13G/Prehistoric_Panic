using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageController : MonoBehaviour
{
    [SerializeField]
    float lifeTime = 1.5F;
    [SerializeField]
    GameObject DialogBox;
    [SerializeField]
    bool first;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DialogBox.SetActive(true);
            if (!first)
            {
            DialogBox.GetComponent<Dialogue>().StartDialogue();
            }
            Destroy(gameObject, lifeTime);
        }
    }
}
