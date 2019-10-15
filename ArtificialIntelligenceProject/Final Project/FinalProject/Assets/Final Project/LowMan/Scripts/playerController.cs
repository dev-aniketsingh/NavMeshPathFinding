using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class playerController : MonoBehaviour {

    public Camera cam;
    public NavMeshAgent agent;
    public ThirdPersonCharacter character;

    // Update is called once per frame
    private void Start()
    {
        agent.updateRotation = false;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                //Move agent
                agent.SetDestination(hit.point);
            }
        }
        if(agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            character.Move(Vector3.zero, false, false);
        }

    }
}
