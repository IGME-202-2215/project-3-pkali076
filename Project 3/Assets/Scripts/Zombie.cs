using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Vehicle
{
    public Human humanFood;

    //[SerializeField]
    //public Transform objectZTransform;
    //public Bounds objectZBounds;

    protected override void CalcSteeringForces()
    {
        Vector3 ultimateForce = Vector3.zero; //default

        ultimateForce += Pursue(humanFood);

        ultimateForce = Vector3.ClampMagnitude(ultimateForce, maxForce);

        ApplyForce(ultimateForce);
    }

    //private void OnDrawGizmosSelected()
    //{
    //    Gizmos.color = Color.magenta;
    //   // Gizmos.DrawWireCube(objectZTransform.position, objectZBounds.center);
    //}
}
