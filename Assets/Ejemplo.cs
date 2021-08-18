using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo : MonoBehaviour
{

    // exponer atributos hacia el editor
    // 2 maneras: haciendo una variable pública
    // la otra: haciendola privada pero serializable
    // recuerda hacer tu juego designer-friendly!
    public float velocidad = 5;

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
        float h = Input.GetAxis("Horizontal");
        // print(h);
        float v = Input.GetAxis("Vertical");

        // 2da cosa por hacer - movimiento
        // A considerar cuando usemos update
        // proporcionar movimiento con Time.deltaTime
        // Time.deltaTime - tiempo transcurrido entre cuadro anterior y actual

        // print(Time.deltaTime);
        transform.Translate(velocidad * h * Time.deltaTime, velocidad * v * Time.deltaTime, 0, Space.World);

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

    // para colision:
    // - todos los involucrados tienen collider
    // - al menos uno tiene rigidbody
    // - el que tiene rigidbody se mueve
    // - los métodos tanto de collision como de trigger se invocan en TODOS los involucrados

    // 3 momentos en la vida de la colision

    // al tocarse inicialmente
    private void OnCollisionEnter(Collision collision)
    {
        // print("collision enter " + collision.gameObject.layer + " " + collision.GetContact(0).point);
        print("collision enter " + collision.gameObject.tag + " " + collision.GetContact(0).point);

        if(collision.gameObject.tag == "Enemigo")
        {
            print("PEW PEW!");
        }

        print(collision.gameObject.layer);
    }

    // mientras se sigan tocando
    private void OnCollisionStay(Collision collision)
    {
        print("collision stay");
    }

    // al momento de separarse
    private void OnCollisionExit(Collision collision)
    {
        print("collision exit");
    }

    // 2 diferencias importantes entre triggers y no triggers
    // 1. Existe feedback físico en no triggers
    // 2. información que podemos obtener de colisión

    private void OnTriggerEnter(Collider other)
    {

        // collider es referencia al objeto collider con el que chocamos (al otro)
        print("trigger enter " + other.name);
    }

    private void OnTriggerStay(Collider other)
    {
        print("trigger stay");
    }

    private void OnTriggerExit(Collider other)
    {
        print("trigger exit");
    }
}
