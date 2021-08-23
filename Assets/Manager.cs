using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    // Singleton - mecanismo que hace que sólo exista una instancia de esta clase (este tipo)

    // agregar una propiedad estática
    public static Manager Instance {
        get;
        private set;
    }

    public float speedGeneral = 10;

    // Start is called before the first frame update
    void Start()
    {

        // verificar que sea el único (y si no destruirme)
        if(Instance == null){
            Instance = this;
        } else {
            Destroy(gameObject);
        }
    }

}
