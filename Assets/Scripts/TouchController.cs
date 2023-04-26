 using UnityEngine;
 using System.Collections;
 using UnityEngine.SceneManagement;
 
 public class TouchController : MonoBehaviour {
     void OnCollisionEnter2D (Collision2D Colider)
     {
         if (Colider.gameObject.name == "Player") {
             SceneManager.LoadScene(1);
         }
     }
 }