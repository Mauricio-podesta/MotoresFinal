using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class CountNotes : MonoBehaviour
{
    public TextMeshProUGUI CantText;
    public int cant= 0;
    
   public void sumar(int value)
    {
        cant+= value;
        UpdateCanttext();
    }
    void UpdateCanttext()
    {
        CantText.text = cant.ToString() + " / 9";
    }
}
