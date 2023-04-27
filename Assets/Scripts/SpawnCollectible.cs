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
 
   private GameObject spawnedCollectible;


   public int collectibleCountToWin = 3;

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


  void Update () {
    
    
   }





 IEnumerator DestroyCollectible() {
      yield return new WaitForSeconds(despawnTime);
      if (spawnedCollectible != null) {
         Destroy(spawnedCollectible);
         spawnedCollectible = null;
      }
   }

   

 

}