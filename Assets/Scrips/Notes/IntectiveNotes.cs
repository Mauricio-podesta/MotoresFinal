using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class IntectiveNotes : MonoBehaviour
{
    private int notes = 1;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            GameManager gameManager = FindObjectOfType<GameManager>();
            
            if (gameManager != null)
            {
               
                gameManager.GetComponent<CountNotes>().sumar(notes);
            }
           
            
            Destroy(gameObject);

        }
    }
}
