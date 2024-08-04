using UnityEngine;

public class TestFlauros : MonoBehaviour
{
    public Texture2D meshT;
    void Start() {
        float size = 1f;
        Vector3[] vertices = {
            //Z siempre profundidad!!!!!!!!!!!!!!!!!!!!!!!!
            // primera izquierda abajo 
            new Vector3(0, 0, 0),    //0

            new Vector3(2.5f, 5, 2.5f),  //1

            new Vector3(5, 0, 0),     //2
            /////////////////////////////////////////// cara izq
            new Vector3(2.5f, 5, 2.5f),    //3

             new Vector3(0, 0, 0), //4

             new Vector3(2.5f, 0, 5), //5
            ///////////////////////////////// cara der
            new Vector3(2.5f, 5, 2.5f), //6

            new Vector3(2.5f, 0, 5), //7

             new Vector3(5, 0, 0),     //8
             ////////////////////////////////////// parte de abajo pirmaide izquierda abajo
             new Vector3(0, 0, 0),    //9

             new Vector3(2.5f, 0, 5), //10

             new Vector3(5, 0, 0),     //11

             ///////////////////////////////////////////// inicia piramide derecha
             new Vector3(5, 0, 0),     //12

             new Vector3(7.5f, 5, 2.5f),  //13

             new Vector3(10, 0, 0),    //14
             /////////////////////////////////////////////////cara izq
              new Vector3(7.5f, 5, 2.5f),  //15

               new Vector3(5, 0, 0),     //16

               new Vector3(7.5f, 0, 5),    //17
            //////////////////////////////////////////////////// cara der
             new Vector3(7.5f, 5, 2.5f),  //18

             new Vector3(7.5f, 0, 5),    //19

             new Vector3(10, 0, 0),    //20
             ///////////////////////////////////////////////////parte abajo piramide der abajo
              new Vector3(5, 0, 0), //21

               new Vector3(7.5f, 0, 5),    //22

               new Vector3(10, 0, 0),    //23
               ///////////////////////////////////////////////////inicia piramide enfrente Z
              new Vector3(2.5f, 0, 5), //24

              new Vector3(5, 5, 7.5f),   //25

               new Vector3(7.5f, 0, 5),    //26
               //////////////////////////////////////////////////////cara izq
               new Vector3(5, 5, 7.5f),   //27

                new Vector3(2.5f, 0, 5), //28

                 new Vector3(5, 0, 10),   //29
                 ///////////////////////////////////////////////////cara der
                new Vector3(5, 5, 7.5f),   //30

                new Vector3(5, 0, 10),   //31

                new Vector3(7.5f, 0, 5),    //32
                ///////////////////////////////////////////////////parte abajo piramide enfrente
                new Vector3(2.5f, 0, 5), //33

                new Vector3(5, 0, 10),   //34

                new Vector3(7.5f, 0, 5),    //35
                ///////////////////////////////////////////////inicia piramide arriba
                 new Vector3(2.5f, 5, 2.5f), //36

                 new Vector3(5, 10, 5),  //37

                 new Vector3(7.5f, 5, 2.5f),  //38
                 ///////////////////////////////////////////////cara izq
                  new Vector3(5, 10, 5),  //39

                   new Vector3(2.5f, 5, 2.5f), //40

                   new Vector3(5, 5, 7.5f),   //41
                ///////////////////////////////////////////////cara der
                new Vector3(5, 10, 5),  //42

                new Vector3(5, 5, 7.5f),   //43

                new Vector3(7.5f, 5, 2.5f),  //44
                /////////////////////////////////////////////parte de abajo piramide de arriba
                new Vector3(2.5f, 5, 2.5f), //45

                new Vector3(5, 5, 7.5f),   //46

                new Vector3(7.5f, 5, 2.5f),  //47
                ////////////////////////////////////////////////////inicia figura 8 carascara que se ve de frente 
                 new Vector3(2.5f, 5, 2.5f), //48

                  new Vector3(7.5f, 5, 2.5f),  //49

                   new Vector3(5, 0, 0), //50
                   /////////////////////////////////////////////////cara izquierda
                    new Vector3(2.5f, 5, 2.5f), //51

                    new Vector3(2.5f, 0, 5), //52

                     new Vector3(5, 0, 0), //53
                /////////////////////////////////////////////////////cara izquiera la parte que se tiene que llenar 
                     new Vector3(2.5f, 5, 2.5f), //54

                     new Vector3(5, 5, 7.5f),   //55

                     new Vector3(2.5f, 0, 5), //56
                ///////////////////////////////////////////////////cara de atras
                     new Vector3(2.5f, 0, 5), //57

                     new Vector3(5, 5, 7.5f),   //58

                     new Vector3(7.5f, 0, 5),    //59
                ///////////////////////////////////////////////////////cara derecha la parte que se tiene que llenar
                new Vector3(7.5f, 5, 2.5f),  //60

                 new Vector3(5, 5, 7.5f),   //61

                 new Vector3(7.5f, 0, 5),    //62
                 //////////////////////////////////////////////////cara derecha
                 new Vector3(7.5f, 5, 2.5f),  //63

                 new Vector3(5, 0, 0), //64

                 new Vector3(7.5f, 0, 5),    //65
                 ///////////////////////////////////////////////parte de arriba
                 new Vector3(2.5f, 5, 2.5f), //66

                 new Vector3(5, 5, 7.5f),   //67

                 new Vector3(7.5f, 5, 2.5f),  //68
                 ///////////////////////////////////////////////parte de abajo
                  new Vector3(2.5f, 0, 5), //69

                  new Vector3(7.5f, 0, 5),    //70

                  new Vector3(5, 0, 0), //71
                
                
                //derecha abajo

           /* new Vector3(5, 0, 0),//repite  //4

            new Vector3(7.5f, 0, 5),    //5

            new Vector3(10, 0, 0),    //6

            new Vector3(7.5f, 5, 2.5f),  //7 
            ///////////////////////////////////////////////
            //enfrente abajo

            new Vector3(2.5f, 0, 5),//repite   //8

            new Vector3(5, 0, 10),            //9

            new Vector3(7.5f, 0, 5),//repite    /10

            new Vector3(5, 5, 7.5f),   //11
            ///////////////////////////////////////////////////
           //punto para la cuspide 
            new Vector3(5, 10, 5),  //12*/

        };

        int[] triangles = {
            //piramide izquierda 
           0, 1, 2, 
			3, 4, 5,
            6, 7, 8, 
			11, 10, 9,
            
            
            //piramide derecha
            12, 13, 14, 
			15, 16, 17,
            18, 19, 20, 
			23, 22, 21,

            /////piramide atras
            24, 25, 26, 
			27, 28, 29,
            30, 31, 32, 
			35, 34, 33,
            ///////piramide arriba
            36,37,38,
            39,40,41,
            42,43,44,
            47,46,45,
            //////////figura del centro 
            48,49,50,
            51,52,53,
            56,55,54,
            57,58,59,
            60,61,62,
            63,64,65,
            68,67,66,
            71,70,69


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
