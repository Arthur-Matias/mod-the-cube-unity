using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float angleX = 0;
    public float angleY = 0;
    public float angleZ = 0;

    void Start()
    {
        transform.position = new Vector3(Random.Range(-2, 5), Random.Range(-1, 5), 1);
        transform.localScale = Vector3.one * Random.Range(1f, 2f);


    }

    void Update()
    {
        Material material = Renderer.material;
        angleX += Random.Range(0.001f, 0.01f);
        angleY += Random.Range(0.001f, 0.01f);
        angleZ += Random.Range(0.001f, 0.01f);
        material.color = new Color(1f * Mathf.Abs(Mathf.Cos(angleX)), 1.0f * Mathf.Abs(Mathf.Sin(angleY)), 1f * Mathf.Abs(Mathf.Cos(angleZ)));
        transform.Rotate(Random.Range(2f, 10.0f) * Time.deltaTime, Random.Range(2f, 10.0f) * Time.deltaTime, Random.Range(2f, 10.0f) * Time.deltaTime);
    }
}
