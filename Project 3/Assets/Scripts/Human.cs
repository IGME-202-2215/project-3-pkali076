using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Vehicle
{

    public Zombie enemyZombie;

    //[SerializeField]
    //public Transform objectHTransform;
    //public Bounds objectHBounds;

    protected override void CalcSteeringForces()
    {
        Vector3 ultimateForce = Vector3.zero;

        ultimateForce += Evade(enemyZombie);

        ultimateForce = Vector3.ClampMagnitude(ultimateForce, maxForce);

        ApplyForce(ultimateForce);
    }
    //private void OnDrawGizmosSelected()
    //{
    //    Gizmos.color = Color.magenta;
    //   // Gizmos.DrawWireCube(objectHTransform.position, objectHBounds.center);
    //}
}
