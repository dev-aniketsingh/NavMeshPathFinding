using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {

  NavMeshAgent agent;
  public Camera cam;

 // Use this for initialization
 void Start () {
        agent = GetComponent<NavMeshAgent>();
        cam = Camera.main;
 }

 // Update is called once per frame
 void Update () {

        // click left mouse button
        if (Input.GetMouseButtonDown(0))
        {
          // create a click from the SCREEN SPACE (2d)
          // into a ray in the WORLD SPACE
          Ray ray = cam.ScreenPointToRay(Input.mousePosition);
          RaycastHit hit;

          // cast the ray and store information of the location the ray has hit
          if (Physics.Raycast(ray, out hit)) // returns true if actually does hit something
          {
              // if the ray its something it is stored in 'hit' (also code )
              // use 'hit' to move our dude
              agent.SetDestination(hit.point); // hit the location the ray hit on naveMesh

          }

        }


    }
}﻿