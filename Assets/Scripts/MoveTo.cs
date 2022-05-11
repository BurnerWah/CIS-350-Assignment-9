/*
 * Jaden Pleasants
 * Assignment 9
 * Moves a navmesh agent to a goal
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour {
    public Transform goal;

    void Start() {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }
}
