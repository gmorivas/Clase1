using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrullero : MonoBehaviour
{

    // ejemplo de lookat
    public Transform objetivo;
    public Transform[] ruta;
    public float limiteDistancia = 0.1f;

    private NavMeshAgent navMeshAgent;
    private int waypointActual;

    // Start is called before the first frame update
    void Start()
    {
        waypointActual = 0;
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.destination = ruta[waypointActual].position;
        StartCoroutine(verificarSiguienteObjetivo());
    }

    // Update is called once per frame
    void Update()
    {

        // lookat - sirve para reorientar el objeto de tal manera
        // Que su frente apunte al objetivo (rotar objeto)
        // transform.LookAt(objetivo);  
    }

    IEnumerator verificarSiguienteObjetivo() {

        while(true) {

            // qué tan frecuente repetir lógica?
            // lo más espaciada posible mientras siga sirviendo
            yield return new WaitForSeconds(0.3f);

            float distancia = Vector3.Distance(transform.position, ruta[waypointActual].position);

            // IMPORTANTE - comparando valores flotantes / doubles (continuos, no enteros)
            // usa rangos para determinar si son ""iguales"" 
            if(distancia < limiteDistancia) {

                // detona cambio de objetivo
                // ++ incremento en 1
                waypointActual++;
                if(waypointActual == ruta.Length)
                    waypointActual = 0;
                
                navMeshAgent.destination = ruta[waypointActual].position;

            }
        }
    }    
}
