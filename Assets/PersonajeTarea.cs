using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeTarea : MonoBehaviour
{

    public float speed = 5;

    private IEnumerator corrutina;

    // Start is called before the first frame update
    void Start()
    {
        corrutina = Disparo();
    }

    // Update is called once per frame
    void Update()
    {
        // 1 - desplazamiento
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(-1 * v * speed * Time.deltaTime, 0, h * speed * Time.deltaTime, Space.World);


        // 2 - orientación
        Ray rayito = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if(Physics.Raycast(rayito, out hit)){

            // arreglando posicion de objetivo
            Vector3 objetivo = new Vector3(hit.point.x, transform.position.y, hit.point.z); 
            transform.LookAt(objetivo);
        }

        if(Input.GetMouseButtonDown(0)){
            StartCoroutine(corrutina);
        }

        if(Input.GetMouseButtonUp(0)){
            StopCoroutine(corrutina);
        }
    }

    IEnumerator Disparo() {

        while(true){

            print("PEW PEW");
            // NOTAS:
            // - posición basada en orientación de jugador
            // - recuerda: tienes el vector forward
            // print(transform.forward);
            yield return new WaitForSeconds(0.8f);
        
        }
    }
}
