using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara1 : MonoBehaviour
{
    Vector2 MouseView;
    Vector2 VectorSmooth;
    [SerializeField] float Sensibility = 3f;
    [SerializeField] float Smooth = 3f;
    GameObject Player;
    void Start()
    {
        Player = this.transform.parent.gameObject;
    }
    void Update()
    {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        md = Vector2.Scale(md, new Vector2(Sensibility * Smooth, Smooth * Sensibility));
        VectorSmooth.x = Mathf.Lerp(VectorSmooth.x, md.x, 1f / Smooth);
        VectorSmooth.y = Mathf.Lerp(VectorSmooth.y, md.y, 1f / Smooth);
        MouseView += VectorSmooth;
        MouseView.y = Mathf.Clamp(MouseView.y, -90f, 90f);
        transform.localRotation = Quaternion.AngleAxis(-MouseView.y, Vector3.right);
        Player.transform.localRotation = Quaternion.AngleAxis(MouseView.x, Player.transform.up);
    }
}
