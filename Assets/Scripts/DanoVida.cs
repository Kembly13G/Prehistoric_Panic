using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoVida : MonoBehaviour
{
    LogicaBarraVida logicaBarraVidaJugador;

    
    public int cantidad;
    public float damageTime;
    float currentDamageTime;

    void Start()
    {
        logicaBarraVidaJugador = GameObject.FindWithTag("Player").GetComponent<LogicaBarraVida>();
    }

    public void OnTriggerEnter(Collider other)
    {
 
        if (other.tag == ("Player"))
        {
            currentDamageTime += Time.deltaTime;

            if(currentDamageTime > damageTime)
            {
                logicaBarraVidaJugador.vidaMax -= cantidad;
                currentDamageTime = 0.0F;
            }
        }
    }
}
