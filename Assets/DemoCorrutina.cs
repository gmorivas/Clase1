using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoCorrutina : MonoBehaviour
{

    private IEnumerator corrutina1;
    private Coroutine corrutina2; 

    // Start is called before the first frame update
    void Start()
    {

        // NOTA: las corrutinas se pueden iniciar en CUALQUIER parte del código
        // error común (evitar) - iniciar corrutinas en update (a menos que tenga sentido)
        corrutina1 = EjemploCorrutina();
        StartCoroutine(corrutina1);
        corrutina2 = StartCoroutine(EjemploCorrutina2());
        StartCoroutine("EjemploCorrutina3");
    }

    // Update is called once per frame
    void Update()
    {

        //aquí NO inicien corrutinas!

        if(Input.GetKeyUp(KeyCode.Space)){

            // como detener corrutinas
            // 1era manera - deten todas
            // StopAllCoroutines();
            
            // 2da manera - usando referencia al IEnumerator
            // StopCoroutine(corrutina1);

            // 3era manera - usando referencia a la corrutina
            // StopCoroutine(corrutina2);

            // 4ta - con un string
            StopCoroutine("EjemploCorrutina3");
        }
    }

    IEnumerator EjemploCorrutina(){

        // no es necesario tener "true" en el ciclo, pueden tener una condicion que considere
        // variables de objeto
        while(true){

            print("MENSAJE DESPUES DE 0.9 SEGUNDOS");
            yield return new WaitForSeconds(0.9f);
            
        }        
    }

    IEnumerator EjemploCorrutina2() {

        while(true){

            print("MENSAJE DESPUES DE 0.5 SEGUNDOS");
            yield return new WaitForSeconds(0.5f);
            
        }
    }

    IEnumerator EjemploCorrutina3() {

        while(true){

            print("MENSAJE DESPUES DE 2 SEGUNDOS");
            yield return new WaitForSeconds(2);
            
        }
    }
}
