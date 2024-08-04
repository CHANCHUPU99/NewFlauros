using UnityEngine;

public class TestFlauros : MonoBehaviour
{
    public Texture2D meshT;
    void Start() {
        float size = 1f;
        Vector3[] vertices = {
            //Z siempre profundidad!!!!!!!!!!!!!!!!!!!!!!!!
            // primera izquierda abajo 
            new Vector3(0, 0, 0),    

            new Vector3(2.5f, 0, 5),    

            new Vector3(5, 0, 0),     

            new Vector3(2.5f, 5, 2.5f),   

            /////////////////////////////////
            //derecha abajo

            //new Vector3(5, 0, 0),

            new Vector3(7.5f, 0, 5),    

            new Vector3(10, 0, 0),    

            new Vector3(7.5f, 5, 2.5f),   
            ///////////////////////////////////////////////
            //enfrente abajo

            // new Vector3(2.5f, 0, 5),

            new Vector3(5, 0, 10),   

            // new Vector3(7.5f, 0, 5),

            new Vector3(5, 5, 7.5f),   
            ///////////////////////////////////////////////////
           //punto para la cuspide 
            new Vector3(5, 10, 5),

        };

        int[] triangles = {
            //piramide izquierda 
           0, 3, 2, 
			3, 0, 1,
            3, 1, 2, 
			2, 1, 0,
            
            
            //piramide derecha
            2, 6, 5, 
			6, 2, 4,
            6, 4, 5, 
			5, 4, 2,

            /////piramide atras
            1, 8, 4, 
			8, 1, 7,
            8, 7, 4, 
			4, 7, 1,
            //////////figura del centro 
            3,1,8,
            8,4,6,
            3,6,2,
            1,2,4,
            8,6,3, 
            ///////piramide arriba
            3,9,6,
            3,8,9,
            9,8,6,


        };

        Vector2[] uvs = {
            new Vector2(0.289f, 0.099f),  // Vértice 0
            new Vector2(0.201f, 0.199f),  // Vértice 1
            new Vector2(0.377f, 0.199f),  // Vértice 2
            new Vector2(0.679f, 0.447f),  // Vértice 3
            new Vector2(0.591f, 0.547f),  // Vértice 4
            new Vector2(0.767f, 0.547f),  // Vértice 5
            new Vector2(0.201f, 0.646f),  // Vértice 6
            new Vector2(0.113f, 0.746f),  // Vértice 7
            new Vector2(0.289f, 0.746f),  // Vértice 8
            new Vector2(0.491f, 0.348f),  // Vértice 9
            new Vector2(0.403f, 0.447f),  // Vértice 10
            new Vector2(0.579f, 0.447f),  // Vértice 11
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
