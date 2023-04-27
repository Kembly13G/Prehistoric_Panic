using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoTransitionController : MonoBehaviour
{
    [SerializeField]
    GameObject Video;
    [SerializeField]
    GameObject Canvas;
    [SerializeField]
    float TimePassed=0;
    [SerializeField]
    float TimeToReach;
    void Start()
    {
        Canvas.SetActive(false);
        Video.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
        if (TimePassed >= TimeToReach)
        {
            Canvas.SetActive(true);
            Video.SetActive(false);
        }
        else
        {
            TimePassed += Time.deltaTime;
        }
    }
}
