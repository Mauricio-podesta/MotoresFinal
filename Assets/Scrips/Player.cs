using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float Speedvalue = 5f;
    public float hp = 10f;
    public AudioSource Grito;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float movementbackfoward = Input.GetAxis("Vertical") * Speedvalue;
        float movementrigthleft = Input.GetAxis("Horizontal") * Speedvalue;
        movementbackfoward *= Time.deltaTime;
        movementrigthleft *= Time.deltaTime;
        transform.Translate(movementrigthleft, 0, movementbackfoward);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Payaso"))
        {
            Grito.Play();
        }
    }
}
