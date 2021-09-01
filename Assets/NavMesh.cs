using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavMesh : MonoBehaviour
{

    private NavMeshAgent navMeshAgent;

    public Transform[] puntos;
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.destination = new Vector3(5, 3, 2);

        // IMPORTANTE! iniciar corrutina!
        StartCoroutine(EjemploCorrutina());

        // resultado similar (peor performance)
        Invoke("MetodoConInvoke", 5);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)) {

            // lanzar rayitos - usando raycast

            // acordarse - el rayo no se ve pero sì se usa para calcular colisiones
            // importante - el rayo choca con lo que tenga collider
            // para NO verificar colision con rayo hay que cambiar la layer del objeto a "Ignore Raycast"

            // hacer un rayo - mouse
            // en este ejemplo lo hacemos desde la camara pero se puede generar desde otras fuentes
            Ray rayito = camera.ScreenPointToRay(Input.mousePosition);
            // Ray rayito = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            // verificar si rayito pegó con algo
            // el objeto "hit" va a ser rellenado con información congruente a la colisión entre el rayo y un collider
            if (Physics.Raycast(rayito, out hit))
            {

                // print("COLISION: " + hit.transform.name + " " + hit.transform.tag + " " + hit.point);

                // cambiar rumbo de objeto que usa navmesh
                // navMeshAgent.destination = hit.point;
            }
            else {
                print("NO COLISIONÓ!");
            }

        }
    }


    // manera "fácil" de usar raycast
    // por medio de eventos
    // (recuerda que tu objeto NO debe estar en la layer Ignore Raycast!)

    // SOLO MOVIMIENTO

    // puntero se sobrepuso a objeto
    private void OnMouseEnter()
    {
        //print("MOUSE ENTER");
    }

    // puntero ya se sobrepuso y sigue sobre el objeto
    private void OnMouseOver()
    {
        // print("MOUSE OVER");
    }

    // el cuadro en donde dejamos de estar sobre el objeto
    private void OnMouseExit()
    {
        //print("MOUSE EXIT");
    }

    // REQUIEREN CLICK

    // click sobre objeto con puntero encima
    private void OnMouseDown()
    {
        print("MOUSE DOWN");
    }

    // después de dar click en objeto movemos el puntero SIN soltar el botón del mouse
    private void OnMouseDrag()
    {
        print("MOUSE DRAG");
    }

    // soltamos botón de mouse donde sea
    private void OnMouseUp()
    {
        print("MOUSE UP");
    }

    // click se dió sobre el objeto Y soltamos el click sobre el objeto
    private void OnMouseUpAsButton()
    {
        print("MOUSE UP AS BUTTON");
    }

    // corrutinas
    // creación de código pseudo concurrente
    // creamos un flujo de lógica que APARENTA ser paralelo
    // TODAS las corrutinas regresan un IEnumerator
    IEnumerator EjemploCorrutina()
    {

        yield return new WaitForSeconds(5);
        print("MENSAJE DESPUÉS DE 5 SEGUNDOS");
    }

    // si nada más es retrasar una invocación también existe invoke
    void MetodoConInvoke() {
        print("5 SEGUNDOS CON INVOKE");
    }
}
