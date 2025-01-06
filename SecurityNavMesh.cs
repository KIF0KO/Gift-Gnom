using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class SecurityNavMesh : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private GameObject target;
    [SerializeField] private GameObject target2;
    [SerializeField] private Animator animator;
    public float distance = 2f;
    public LayerMask layerMask;
    public bool isDirection = false;

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isWalk", true);
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * distance);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, distance, layerMask))
        {
            if (hit.collider != null)
            {
                Destinations(isDirection);
            }
        }
    }


    private void Destinations(bool direction)
    {
        if (direction)
        {
            agent.SetDestination(target.transform.position);
            target.SetActive(true);
            target2.SetActive(false);
        }
        else
        {
            agent.SetDestination(target2.transform.position);
            target.SetActive(false);
            target2.SetActive(true);
        }
        isDirection = !isDirection;
    }
}
