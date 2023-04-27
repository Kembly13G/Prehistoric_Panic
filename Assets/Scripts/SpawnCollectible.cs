using System;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnCollectible : MonoBehaviour
{

    public GameObject collectiblePrefab;
    public float spawnTime = 5f;
    public float despawnTime = 5f;

    GameObject spawnedCollectible;

    IEnumerator DestroyCollectible()
    {
        yield return new WaitForSeconds(despawnTime);
        if (spawnedCollectible != null)
        {
            Destroy(spawnedCollectible);
            spawnedCollectible = null;
        }
    }

}
