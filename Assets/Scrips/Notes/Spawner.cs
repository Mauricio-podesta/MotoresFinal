using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn; // Prefab del objeto a spawnear
    [SerializeField] private int spawnCount = 10; // Cantidad de objetos a generar
    [SerializeField] private GameObject terrain; // Terreno donde se generar�n los objetos

    void Start()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            // Generar posici�n aleatoria en el terreno
            Vector3 spawnPosition = GetRandomPositionOnTerrain();

            // Instanciar el objeto
            Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
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

        // Calcular un punto aleatorio dentro del �rea del Collider
        float randomX = Random.Range(terrainCollider.bounds.min.x, terrainCollider.bounds.max.x);
        float randomZ = Random.Range(terrainCollider.bounds.min.z, terrainCollider.bounds.max.z);

        // Usar la altura del plano como la posici�n Y
        float yPosition = terrainCollider.bounds.min.y;

        return new Vector3(randomX, yPosition, randomZ);
    }
}
