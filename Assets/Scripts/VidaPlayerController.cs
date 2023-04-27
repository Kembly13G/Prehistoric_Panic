using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayerController : MonoBehaviour
{
    public float vida = 100;

    public Image BarraHp;

    // Update is called once per frame
    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);

        BarraHp.fillAmount = vida / 100;
    }
}
