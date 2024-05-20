using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random=UnityEngine.Random;

public class Block : MonoBehaviour
{
    public Transform[] blockPoints;
    public GameObject  blockPrefabs;

    public float spawnMid = 1f;
    private float spawnTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       if(Time.time >= spawnTime)
       {
        Spawn();
        spawnTime = Time.time + spawnMid; 
       }
    }
    void Spawn()
    {
       int randomIndex = Random.Range(0, blockPoints.Length);

		for (int i = 0; i < blockPoints.Length; i++)
		{
			if (randomIndex != i)
			{
				Instantiate(blockPrefabs, blockPoints[i].position, Quaternion.identity);
			}
		}
    }
}
