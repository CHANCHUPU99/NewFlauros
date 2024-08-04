using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


    [RequireComponent(typeof(MeshFilter))]
    [RequireComponent(typeof(MeshRenderer))]
    public class Cube : MonoBehaviour
    {
    public Texture2D meshT;
    void Start() {
        float size = 1f;
        Vector3[] vertices = {
            new Vector3(0, 0, 0),
            new Vector3(0, 0, 6),
            new Vector3(2, 6, 3),
            new Vector3(6, 0, 0),
            new Vector3(6, 0, 0),
            new Vector3(12, 0, 0),
            new Vector3(10, 6, 3), //6
            new Vector3(12, 0, 6),
            new Vector3(6, 6, 8),
            new Vector3(6, 0, 12),
            new Vector3(6, 12, 5), //10
            //inicia centro
            new Vector3(0, 0, 6),
            new Vector3(0, 6, 6),
            new Vector3(6, 6, 3),
            //
            new Vector3(12, 0, 6),
            new Vector3(11, 6, 3),
            //
            new Vector3(6, 0, 0),
        };

        int[] triangles = {
            0, 1, 2, // front
            0, 2, 3,
            1, 4, 2, // back
            5, 3, 6,
            7, 5, 6, //top
            3, 7, 6,
            7, 1, 8, //bottom
            1, 9, 8,
            9, 7, 8,// left
            2, 8, 6,
            2, 10, 6,//right
            8, 6, 10,
            2, 8, 10,
            //centro
            2, 1, 8,
            7, 8, 6,
            3, 2, 6,
            //centro bajo
            // 3, 1, 7,
        };

        Vector2[] uvs = {
            // Coordenadas UV basadas en los vértices clave identificados
            new Vector2(0.289f, 0.099f),  // A1
            new Vector2(0.201f, 0.199f),  // A2
            new Vector2(0.377f, 0.199f),  // A3
            new Vector2(0.679f, 0.447f),  // B1
            new Vector2(0.591f, 0.547f),  // B2
            new Vector2(0.767f, 0.547f),  // B3
            new Vector2(0.201f, 0.646f),  // C1
            new Vector2(0.113f, 0.746f),  // C2
            new Vector2(0.289f, 0.746f),  // C3
            new Vector2(0.491f, 0.348f),  // D1
            new Vector2(0.403f, 0.447f),  // D2
            new Vector2(0.579f, 0.447f),  // D3
            // Añadir más coordenadas UV si es necesario
        };

        /*Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        mesh.Optimize();
        mesh.RecalculateNormals();

        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        Material material = new Material(Shader.Find("Standard"));
        material.mainTexture = meshT;
        meshRenderer.material = material;*/

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }
}
