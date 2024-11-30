using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angelesdevientosonido : MonoBehaviour
{
    public AudioSource Angel;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Angel.Play();
        }   
    }
}