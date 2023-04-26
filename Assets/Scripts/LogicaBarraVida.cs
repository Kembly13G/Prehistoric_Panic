using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaBarraVida : MonoBehaviour
{
    public float vidaMax = 100;

    public Image imagenBarraVida;


    // Update is called once per frame
    void Update()
    {
        vidaMax = Mathf.Clamp(vidaMax, 0, 100);

        imagenBarraVida.fillAmount = vidaMax / 100;
    }

}
