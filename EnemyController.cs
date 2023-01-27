using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float speed = 30f;
    private GameObject Player;
    private UnityEngine.AI.NavMeshAgent Enemy;


    void Start()
    {
        Enemy = GetComponent<UnityEngine.AI.NavMeshAgent>();
        Player = GameObject.Find("Player");
        Enemy.speed = speed;
    }

    void Update()
    {
        Enemy.SetDestination(Player.transform.position);
    }
}
