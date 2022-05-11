/*
 * Jaden Pleasants
 * Assignment 9
 * Enemy AI Handler
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;
public class EnemyAI : MonoBehaviour {
    Camera cam;
    NavMeshAgent agent;
    ThirdPersonCharacter character;
    GameObject player;
    float chaseDistance;

    void Start() {
        character = GetComponent<ThirdPersonCharacter>();
        agent = GetComponent<NavMeshAgent>();
        cam = Camera.main;
        agent.updateRotation = false;
        player = GameObject.FindGameObjectWithTag("Player");
        chaseDistance = 0.8f;
    }

    void Update() {
        MoveEnemy();
    }

    void MoveEnemy() {
        var distanceFromTarget = Vector3.Distance(transform.position, player.transform.position);
        if (distanceFromTarget > agent.stoppingDistance && distanceFromTarget < chaseDistance) {
            agent.destination = player.transform.position;
            character.Move(agent.desiredVelocity, false, false);
        } else {
            agent.destination = transform.position;
            character.Move(Vector3.zero, false, false);
        }
    }
}
