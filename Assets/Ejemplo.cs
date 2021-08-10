using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo : MonoBehaviour
{
    // métodos (funciones) del ciclo de vida
    void Awake()
    {
        print("AWAKE");
    }

    // Start is called before the first frame update
    void Start()
    {
        // estos son métodos
        // es el lugar donde podemos inyectar comportamiento
        // Visual Studio es un IDE - Integrated Development Environment
        Debug.Log("START");
    }

    // Update is called once per frame
    void Update()
    {
        // sucede mientras el loop del juego esté activo
        // tantas veces por segundo se pueda
        // desempeño lo medimos por frames
        // mínimo aceptable - 30 fps
        // target - 60 fps

        // limitar a movimiento / input
        // print("UPDATE");

        // 1era manera de recibir input
        // polling directo a dispositivo

        if (Input.GetKeyDown(KeyCode.J)) {

            print("J DOWN");
        }

        if (Input.GetKey(KeyCode.J)) {
            print("J KEY");
        }

        if (Input.GetKeyUp(KeyCode.J))
        {

            print("J UP");
        }

        if (Input.GetMouseButtonDown(0))
        {
            print("MOUSE DOWN");
        }

        if (Input.GetMouseButton(0))
        {
            print("MOUSE");
        }

        if (Input.GetMouseButtonUp(0))
        {
            print("MOUSE UP");
        }

        // 2da estrategia de input
        // polling de ejes

        // obtenemos el valor del eje como un flotante
        // valores se encuentran en rango [-1, 1]
        //float h = Input.GetAxis("Horizontal");
        float h = Input.GetAxisRaw("Horizontal");
        print(h);
    }

    private void LateUpdate()
    {
        // caso de uso - cuando necesitamos configurar algún valor / escenario
        // antes del siguiente update
        // print("LATE UPDATE");
    }

    // fixed - fijo
    private void FixedUpdate()
    {
        // print("FIXED UPDATE");
    }
}
