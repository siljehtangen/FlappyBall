using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeSpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cone;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    void Start()
    {
        Instantiate(cone, transform.position, transform.rotation);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnCone();
            timer = 0;
        }
        
    }
    void spawnCone(){
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(cone, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint),0), transform.rotation);
    }
}
