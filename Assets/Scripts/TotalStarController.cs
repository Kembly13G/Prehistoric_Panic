using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TotalStarController : MonoBehaviour
{
    [SerializeField]
    float TotalCollectible;

    public void ObtainedCollectibles(float collectible)
    {
        TotalCollectible += collectible;

        if (TotalCollectible >= 5)
        {
            SceneManager.LoadScene(2);
        }
    }
}
