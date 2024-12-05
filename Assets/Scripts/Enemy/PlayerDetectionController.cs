using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetectionController : MonoBehaviour
{
    public bool DetectionPlayer {  get; private set; }
    public Vector2 DirectionToPlayer {  get; private set; }

    [SerializeField] private float playerDetectionDistance;

    private Transform player;

    private void Awake()
    {
        player = FindObjectOfType<PlayerController>().transform;
    }

    // Calculate the direction and check the distance between the enemy and the player.
    void Update()
    {
        Vector2 enemyToPlayerVector = player.position - transform.position;
        DirectionToPlayer = enemyToPlayerVector.normalized;
        if (enemyToPlayerVector.magnitude <= playerDetectionDistance)
        {
            DetectionPlayer = true;
        }
        else
        {
            DetectionPlayer = false;
        }
    }
}
