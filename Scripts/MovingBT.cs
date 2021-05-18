using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBT : MonoBehaviour
{
    public GameObject StartBt;

    Transform tf;
    Vector3 OriginPos;
    float rrange = 0;
    public float translationTime = 3f;
    public float startTime = 2f;


    void Awake()
    {
        tf = transform;
        OriginPos = tf.position;
    }
    void Start()
    {
        
    }

    void Update()
    {
        rrange = Mathf.Clamp((Time.time - startTime) / translationTime, 0, 1);
        tf.position = Vector3.Lerp(OriginPos, OriginPos + new Vector3(12f, 0, 12f), rrange);


    }
}
