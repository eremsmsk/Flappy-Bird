using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject pipePrefab;
    public float minY;
    public float maxY;
    public float x;
    public float interval;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", interval, interval);
    }

    private void spawn()
    {
        GameObject instance = Instantiate(pipePrefab);
        instance.transform.position = new Vector2(x, Random.Range(minY, maxY));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
