using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn; // Prefab del objeto a spawnear
    [SerializeField] private int spawnCount = 10; // Cantidad de objetos a generar
    [SerializeField] private Terrain terrain; // Terreno donde se generarán los objetos
    [SerializeField] private float heightOffset = 0.5f;
    [SerializeField] private GameObject canvasToActivate;
    [SerializeField] private GameObject enemyToActivate;
    private int touch = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (canvasToActivate != null)
            {
                canvasToActivate.SetActive(true);
            }
            if (enemyToActivate != null)
            {
                enemyToActivate.SetActive(true);
            }
            if (touch < 1)
            {
                SpawnObjects();
            }
        }
        
    }
    void Start()
    {

        if (enemyToActivate !=null) 
        {
            Debug.Log("error");
            enemyToActivate.SetActive(false);
        }
        if (canvasToActivate != null)
        {
            canvasToActivate.SetActive(false);
        }
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
        touch = 1;
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
    }
}
