using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField]
    GameObject humanPrefab, zombiePrefab;

    [SerializeField]
    List<Human> humans = new List<Human>();

    [SerializeField]
    List<Zombie> zombies = new List<Zombie>();

    [SerializeField]
    Transform worldTransform;
    Vector3 worldSize = Vector3.zero;
  //  Bounds worldBounds;

    // Start is called before the first frame update
    void Start()
    {
        worldSize = worldTransform.localScale * 10f;

        //worldBounds = new Bounds(worldTransform.position, worldTransform.localScale * 10f);
       // worldBounds = new Bounds(worldTransform.position, worldTransform.localScale * 10f);

        humans.Add(Instantiate(humanPrefab).GetComponent<Human>());
        zombies.Add(Instantiate(zombiePrefab).GetComponent<Zombie>());

      //  humans[0].objectHBounds = worldBounds;
        humans[0].enemyZombie = zombies[0];

       // zombies[0].objectZBounds = worldBounds;
        zombies[0].humanFood = humans[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireCube(worldTransform.position, worldSize);
    }

    //private bool CheckForCollisions(Human humans, Zombie zombies)
    //{

    //}
}
