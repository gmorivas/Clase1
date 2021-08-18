using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    
    // variables de objeto (para uso en todos los métodos)

    // funcionalidad comun - acceder a un componente por medio de código
    // es necesario obtener referencia a el rigidbody
    Rigidbody rb;
    public float force = 10;

    // Start is called before the first frame update
    void Start()
    {
        // obtener la referencia (aquí va la lógica)
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * force, ForceMode.Impulse);
        Destroy(gameObject, 5);
    }

    void OnCollisionEnter(Collision c){

        if(c.gameObject.tag == "Ladrillo"){

            Destroy(gameObject);
            //Destroy(c.gameObject);
        }
    }
}
