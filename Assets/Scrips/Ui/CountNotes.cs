using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class CountNotes : MonoBehaviour
{
    public TextMeshProUGUI CantText;
    public int currentNotes = 0;
    
   public void sumar(int value)
    {
        currentNotes += value;
        UpdateCanttext();
    }
    void UpdateCanttext()
    {
        CantText.text = currentNotes.ToString() + " / 9";
    }
    public int GetNotes()
    {
        return currentNotes; 
    }
}
