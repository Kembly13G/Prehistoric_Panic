using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManipularVidaController : MonoBehaviour
{
    VidaPlayerController VidaPlayer;

    public int cantidad;
    public float damageTime;
    public float currentDamageTime;

    // Start is called before the first frame update
    void Start()
    {
        VidaPlayer = GameObject.FindWithTag("Player").GetComponent<VidaPlayerController>();
    }

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            currentDamageTime += Time.deltaTime;
            if(currentDamageTime > damageTime)
            {
                VidaPlayer.vida += cantidad;
                currentDamageTime = 0.0F;

                if(VidaPlayer.vida <= 0)
                {
                    SceneManager.LoadScene(1);
                }
            }
        }
    }
}
