using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public Camera cam;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        //camera = Camera.main;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)){
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            print("pos mouse " + Input.mousePosition);
            if (Physics.Raycast(ray, out hit)){
                Vector3 pos = hit.point;
                agent.destination = pos;
                print(pos);
            }

        }
    }
}
