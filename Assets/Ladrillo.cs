using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladrillo : MonoBehaviour
{

    void OnCollisionEnter(Collision c){

        if(c.gameObject.tag == "Proyectil")
            Destroy(gameObject);
    }
}
