using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float speed = 30f;
    private GameObject Player;
    private UnityEngine.AI.NavMeshAgent Enemy;


    //laat de enemy naar de speler lopen
    void Start()
    {
        Enemy = GetComponent<UnityEngine.AI.NavMeshAgent>();
        Player = GameObject.Find("Player");
        Enemy.speed = speed;
    }

    //update de positie van de player
    void Update()
    {
        Enemy.SetDestination(Player.transform.position);
    }
}
