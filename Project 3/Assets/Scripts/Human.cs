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
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(1, 1, 1));
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }


}
