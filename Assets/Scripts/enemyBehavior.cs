using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemyBehavior : MonoBehaviour
{
    private NavMeshAgent enemyNavMesh;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float followDistance = 1100f; 
    [SerializeField] private float lookRotationSpeed = 2f; 
    private Vector3 originalPosition; 
    private bool FollowingPlayer = false; 

    private void Awake()
    {
        enemyNavMesh = GetComponent<NavMeshAgent>();
        originalPosition = transform.position; 
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

        if (distanceToPlayer <= followDistance)
        {
            
            enemyNavMesh.SetDestination(playerTransform.position);
            FollowingPlayer = true;
        }
        else
        {
            
            if (FollowingPlayer)
            {
                enemyNavMesh.SetDestination(originalPosition);
                FollowingPlayer = false;
            }

            
   
        }
    }
}
