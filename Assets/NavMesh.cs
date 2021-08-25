using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavMesh : MonoBehaviour
{

    private NavMeshAgent navMeshAgent;

    public Transform[] puntos;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.destination = new Vector3(5, 3, 2);  
    }

    // Update is called once per frame
    void Update()
    {

    }
}
