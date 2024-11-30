using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasosSonido : MonoBehaviour
{
    public AudioSource Pasos;
    void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetButtonDown("Vertical") || Input.GetButtonDown("Horizontal"))
        {
            Pasos.Play();
        }
       if(Input.GetButtonUp("Vertical")|| Input.GetButtonUp("Horizontal")) 
            Pasos.Pause();
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //        if (collision.gameObject.CompareTag("piso"))
    //        {
    //            Pasos.Play();
    //            Debug.Log("hola toca piso");
    //        }

    //}
}
