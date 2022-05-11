/*
 * Jaden Pleasants
 * Assignment 9
 * Moves a navmesh agent to a point clicked
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MoveToClickPoint : MonoBehaviour {
    public Camera cam;
    public NavMeshAgent agent;

    void Start() {
        cam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit)) {
                agent.destination = hit.point;
            }
        }
    }
}
