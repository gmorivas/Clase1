using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // para escuchar botonazo
    // - publico
    // - no regresa nada
    // - no recibe nada
    public void BotonPresionado() {

        print("CLICK");

        if(Time.timeScale == 0)
            Time.timeScale = 1;
        else
            Time.timeScale = 0;
    }

    public void SliderMovido(float valor) {

        print("valor movido: " + valor);
    }
}
