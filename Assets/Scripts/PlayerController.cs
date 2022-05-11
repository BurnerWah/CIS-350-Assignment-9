/*
 * Jaden Pleasants
 * Assignment 9
 * Moves a navmesh agent to a point clicked (but with some extras)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;
public class PlayerController : MonoBehaviour {
    public Camera cam;
    public NavMeshAgent agent;
    public ThirdPersonCharacter character;

    void Start() {
        character = GetComponent<ThirdPersonCharacter>();
        agent = GetComponent<NavMeshAgent>();
        cam = Camera.main;
        agent.updateRotation = false;
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit)) {
                agent.destination = hit.point;
            }
        }
        if (agent.remainingDistance > agent.stoppingDistance) {
            character.Move(agent.desiredVelocity, false, false);
        } else {
            character.Move(Vector3.zero, false, false);
        }
    }
}
