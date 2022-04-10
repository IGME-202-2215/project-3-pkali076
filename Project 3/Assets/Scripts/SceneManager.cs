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
    Bounds worldBounds;


    //vehicle have reference to scene manager
    //scene manager is parent of giving information in world to each vehicle

    // Start is called before the first frame update
    void Start()
    {
        worldSize = worldTransform.localScale * 10f;

        //worldBounds = new Bounds(worldTransform.position, worldTransform.localScale * 10f);
       // worldBounds = new Bounds(worldTransform.position, worldTransform.localScale * 10f);

        humans.Add(Instantiate(humanPrefab).GetComponent<Human>());
        zombies.Add(Instantiate(zombiePrefab).GetComponent<Zombie>());


        //Instantiate(prefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);

        //defaults are 0,0,0 when instantiated.
        //overloads to give default starting location (or random) and rotation
        //quaternion.identity to have rotation that is 0, 0, 0

        //  humans[0].objectHBounds = worldBounds;
        humans[0].sceneManager = this; // zombies[0];

        // zombies[0].objectZBounds = worldBounds;
        zombies[0].sceneManager = this;

        //both zombies and humans have access to public variables from sceneManager
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
