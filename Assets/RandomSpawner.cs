using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject cubePrefab;

    void Start()
{
for(int i=0; i< 100; i++)
{
float x = 3*Mathf.Cos(2 * Mathf.PI * i / 100);
float y = 3*Mathf.Sin(2 * Mathf.PI * i / 100);
Instantiate(cubePrefab, new Vector3(x, 1, y), Quaternion.identity);
}
}
}