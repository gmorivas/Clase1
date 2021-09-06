using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public float speed = 5;
    public float rotationSpeed = 10;

    public GameObject original;
    public Transform referencia;
    public float fuerzaProyectil;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(0, 0, speed * h * Time.deltaTime);
        transform.Rotate(0, 0, rotationSpeed * -v * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space)){

            // aquí es donde clonamos
            // cómo obtenemos referencia a un objeto recién creado?
            GameObject nuevo = Instantiate(original, referencia.position, referencia.rotation);

            // Importante: objeto de tipo game object hace referencia al gameobject completo
            // osea, no a un componente en específico
            print(nuevo.layer + " " + nuevo.tag);

            Proyectil nuevoProyectil = nuevo.GetComponent<Proyectil>();
            nuevoProyectil.force = fuerzaProyectil;
        }
    }
}
