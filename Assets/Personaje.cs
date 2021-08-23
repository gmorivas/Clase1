using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// forzamos a incluir al componente 
[RequireComponent(typeof(CharacterController))]
public class Personaje : MonoBehaviour
{

    private CharacterController characterController;

    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
        // puede ser que pidamos un componente que no tenemos
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 2 metodos en character controller
        // simple move - se encarga de desplazamiento con un vector
        // ya escala el desplazamiento 
        // incluye gravedad 
        // y  es ignorada
        characterController.SimpleMove(new Vector3(v, 0, -h) * Manager.Instance.speedGeneral);


        // alternativa : move
        // NO escala por tiempo 
        // NO incluye cálculos de caida
        // NO ignora la y
        //characterController.Move(new Vector3(v, 0, -h) * Time.deltaTime * speed);

        // cuál elegir:
        // - mi personaje no brinca / vuela / tiene desplazamiento vertical: simple move
        // - otro caso: move
    }

    private void OnControllerColliderHit(ControllerColliderHit hit) {
        
        print("COLISION CON: " + hit.gameObject.name);
    }
}
