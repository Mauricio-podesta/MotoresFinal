using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassScene : MonoBehaviour
{
    [SerializeField] private GameObject objectToActivate;
    [SerializeField] private GameObject objectToDeactivate;
    [SerializeField] private int notesToActivate = 9; 
    private CountNotes countNotes; 

    private void Start()
    {
       
        GameManager gameManager = FindObjectOfType<GameManager>();
        if (gameManager != null)
        {
            countNotes = gameManager.GetComponent<CountNotes>();
        }

        
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(false);
        }
    }

    private void Update()
    {
        if (countNotes != null && countNotes.GetNotes() >= notesToActivate)
        {
            
            if (objectToActivate != null)
            {
                objectToActivate.SetActive(true);
                
            }
            if (objectToDeactivate != null)
            { 
                objectToDeactivate.SetActive(false); 
            }
        }
    }
    
}

