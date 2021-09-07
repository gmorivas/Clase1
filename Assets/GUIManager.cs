using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{

    public Text textito;
    public Slider slider;
    public Button button;

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

        if(Time.timeScale == 0){
            Time.timeScale = 1;
            textito.text = "DESPAUSADO";
        }            
        else{
            Time.timeScale = 0;
            textito.text = "PAUSADO";
        }
            
    }

    public void SliderMovido() {

        print("valor movido: " + slider.value);
        textito.text = slider.value + "";
    }
}
