using System;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnCollectible : MonoBehaviour
{
    [SerializeField]
    float visibleTime = 5f;

    [SerializeField]
    float currentTime = 0f;

    void Update()
    {
        transform.Rotate(new Vector3(0f, 90f, 0f) * Time.deltaTime);

        currentTime += Time.deltaTime;

        if(currentTime >= visibleTime)
        {
            currentTime = 0;

            gameObject.GetComponent<Renderer>().enabled = !gameObject.GetComponent<Renderer>().enabled;
        }
    }

}
