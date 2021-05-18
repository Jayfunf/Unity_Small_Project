using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{

    public float bgSpeed = 1;
    float move;

    Renderer renderer;
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        move += Time.deltaTime * bgSpeed;
        renderer.material.mainTextureOffset = new Vector2(0, move);
    }
}
