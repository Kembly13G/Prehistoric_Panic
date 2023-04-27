using System;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starcontroller : MonoBehaviour
{
   [SerializeField]
    float TotalCollectible;
    public int collectibleCountToWin = 3;

    public void ObtainedCollectibles(float collectible)
    {
        TotalCollectible += collectible;
        if(collectibleCountToWin >= 3){
            SceneManager.LoadScene("Win");
        }

    }
}
