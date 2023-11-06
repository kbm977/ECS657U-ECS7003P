using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private bool isTeleported = false;
    public Camera cam;
    public NavMeshAgent agent;
        
    // Update is called once per frame
    void Update()
    {
        if (isTeleported)
        {
            agent.isStopped = true;

            if (Input.GetMouseButtonDown(0))
            {
                isTeleported = false;
            }
        }
        else
        {
            agent.isStopped = false;
        }

            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);  
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    agent.SetDestination(hit.point);
                }
            }
    }

    public void SetTeleported(bool teleported)
    {
        isTeleported = teleported;
    }
}






