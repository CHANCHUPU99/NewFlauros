using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


    [RequireComponent(typeof(MeshFilter))]
    [RequireComponent(typeof(MeshRenderer))]
    public class Cube : MonoBehaviour
    {
        public Texture2D meshT;
        void Start()
        {
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
            //triangulo arriba derecha imagen 
            new Vector2(0.97f, 0.94f),
            new Vector2(0.72f, 0.94f),
            new Vector2(0.84f, 0.77f),
            //siguiente
            new Vector2(0.72f, 0.94f),
            new Vector2(0.84f, 0.77f),
            new Vector2(0.59f, 0.77f),
           //siguiente
            new Vector2(0.84f, 0.77f),
            new Vector2(0.59f, 0.77f),
            new Vector2(0.72f, 0.60f),
            //siguiente
            new Vector2(0.84f, 0.77f),
            new Vector2(0.97f, 60f),
            new Vector2(0.72f, 60f),
            //siguiente
            new Vector2(0.97f, 60f),
            new Vector2(0.72f, 60f),
            new Vector2(0.84f, 0.43f),
            //siguiente
            new Vector2(0.72f, 60f),
            new Vector2(0.84f, 0.43f),
            new Vector2(0.59f, 0.43f),
            //siguiente 
            new Vector2(0.84f, 0.43f),
            new Vector2(0.59f, 0.43f),
            new Vector2(1.38f, 0.26f),
            //siguiente
            new Vector2(0.84f, 0.43f),
            new Vector2(0.97f, 0.26f),
            new Vector2(1.38f, 0.26f),
            //acabo el de enmedio 

            //inicial piramide de asta abajo a la derecha
            new Vector2(0.60f, 0.38f),
            new Vector2(0.73f, 0.21f),
            new Vector2(0.48f, 0.21f),
            //triangulo de enmedio de piramide
            new Vector2(0.73f, 0.21f),
            new Vector2(0.48f, 0.21f),
            new Vector2(0.60f, 0.04f),
            //este es el triangulo de abajo a la derecha de la piramide 
            new Vector2(0.73f, 0.21f),
            new Vector2(0.85f, 0.04f),
            new Vector2(0.60f, 0.04f),
            //siguiente
            new Vector2(0.48f, 0.21f),
            new Vector2(0.60f, 0.04f),
            new Vector2(0.35f, 0.04f),

            //inicia piramide de abajo a la izquierda 
            new Vector2(0.29f, 0.04f),
            new Vector2(0.42f, 0.21f),
            new Vector2(0.17f, 0.21f),
            //siguiente(es gris)
            new Vector2(0.30f, 0.38f),
            new Vector2(0.42f, 0.21f),
            new Vector2(0.17f, 0.21f),
            //Siguietne(rojo)
            new Vector2(0.42f, 0.21f),
            new Vector2(0.54f, 0.38f),
            new Vector2(0.30f, 0.38f),
            //siguiente(rojo izq)
            new Vector2(0.17f, 0.21f),
            new Vector2(0.30f, 0.38f),
            new Vector2(0.05f, 0.39f),
            //termina

            //piramide de enmedio a la izquierda 
            new Vector2(0.26f, 0.76f),
            new Vector2(0.38f, 0.59f),
            new Vector2(0.14f, 0.60f),
            //triangulo enmedio gris
            new Vector2(0.38f, 0.59f),
            new Vector2(0.26f, 0.43f),
            new Vector2(0.14f, 0.60f),
            //triangulo derecha rojo
            new Vector2(0.38f, 0.59f),
            new Vector2(0.51f, 0.42f),
            new Vector2(0.26f, 0.43f),
            //triangulo izquierda rojo
            new Vector2(0.14f, 0.60f),
            new Vector2(0.25f, 0.43f),
            new Vector2(0.01f, 0.43f),
            //termina

            //piramide hasta arriba a la izquierda
            //rojo derecho
            new Vector2(0.66f, 0.95f),
            new Vector2(0.53f, 0.78f),
            new Vector2(0.41f, 0.95f),
            //gris enmedio
            new Vector2(0.41f, 0.95f),
            new Vector2(0.53f, 0.78f),
            new Vector2(0.28f, 0.78f),
            //rojo izquierda
            new Vector2(0.41f, 0.95f),
            new Vector2(0.28f, 0.78f),
            new Vector2(0.15f, 0.95f),
            //rojo abajo
            new Vector2(0.53f, 0.78f),
            new Vector2(0.40f, 0.61f),
            new Vector2(0.28f, 0.78f)
            //termina
        };


        /* Mesh mesh = GetComponent<MeshFilter>().mesh;
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
