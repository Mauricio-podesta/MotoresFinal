using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn; // Prefab del objeto a spawnear
    [SerializeField] private int spawnCount = 10; // Cantidad de objetos a generar
    [SerializeField] private GameObject terrain; // Terreno donde se generarán los objetos
    [SerializeField] private float heightOffset = 0.5f;
    void Start()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            // Generar posición aleatoria en el terreno
            Vector3 spawnPosition = GetRandomPositionOnTerrain();

            spawnPosition.y += heightOffset;

            // Instanciar el objeto
            Instantiate(objectToSpawn, spawnPosition, Quaternion.Euler(90, 0 , 0));
        }
    }

    Vector3 GetRandomPositionOnTerrain()
    {
        Collider terrainCollider = terrain.GetComponent<Collider>();
        if (terrainCollider == null)
        {
            Debug.LogError("El GameObject asignado no tiene un Collider.");
            return Vector3.zero;
        }

        // Calcular un punto aleatorio dentro del área del Collider
        float randomX = Random.Range(terrainCollider.bounds.min.x, terrainCollider.bounds.max.x);
        float randomZ = Random.Range(terrainCollider.bounds.min.z, terrainCollider.bounds.max.z);

        // Usar la altura del plano como la posición Y
        float yPosition = terrainCollider.bounds.min.y;

        return new Vector3(randomX, yPosition, randomZ);
    }
}
/*[SerializeField] private GameObject objectToSpawn; // Prefab del objeto a spawnear
[SerializeField] private int spawnCount = 10; // Cantidad de objetos a generar
[SerializeField] private Terrain terrain; // Terreno donde se generarán los objetos

void Start()
{
    SpawnObjects();
}

void SpawnObjects()
{
    for (int i = 0; i < spawnCount; i++)
    {
        // Generar posición aleatoria en el terreno
        Vector3 spawnPosition = GetRandomPositionOnTerrain();

        // Instanciar el objeto
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}

Vector3 GetRandomPositionOnTerrain()
{
    // Obtener las dimensiones del terreno
    float terrainWidth = terrain.terrainData.size.x;
    float terrainLength = terrain.terrainData.size.z;

    // Generar coordenadas X y Z aleatorias dentro del terreno
    float randomX = Random.Range(0, terrainWidth);
    float randomZ = Random.Range(0, terrainLength);

    // Obtener la altura Y del terreno en la posición (X, Z)
    float yPosition = terrain.SampleHeight(new Vector3(randomX, 0, randomZ)) + terrain.transform.position.y;

    return new Vector3(randomX + terrain.transform.position.x, yPosition, randomZ + terrain.transform.position.z);
}*/