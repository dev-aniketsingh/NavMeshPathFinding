using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class playerFollowScript : MonoBehaviour {
    public Camera cam;
    public NavMeshAgent agent;
    public ThirdPersonCharacter character;
    public Transform followPlayerTransform;
    public Transform agentPosition;
    //public bool follow = false;
    //public float stoppingDistance;


    // Update is called once per frame
    private void Start() {
        agent.updateRotation = false;
    }
    void Update() {
        agent.SetDestination(followPlayerTransform.position);
        var distance = Vector3.Distance(agentPosition.position,followPlayerTransform.position);

        if (distance <= 2)
        {
            agent.Stop();
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            agent.Resume();

        }
      
    }
}
