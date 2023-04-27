using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController1 : MonoBehaviour
{
  [SerializeField]
    float TotalCollectible;

    public void ObtainedCollectibles(float collectible)
    {
        TotalCollectible += collectible;
        
    }


}
