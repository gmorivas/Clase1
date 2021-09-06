using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponenteDemo : MonoBehaviour
{

    public float vida = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // estos no se llaman voids
    // nombre correcto: método
    // función
    public void MetodoAccesibleATodos(string mensaje){

        print(mensaje);
    }
}
