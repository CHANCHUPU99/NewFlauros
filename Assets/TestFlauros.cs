using UnityEngine;

public class TestFlauros : MonoBehaviour
{
    public Material meshT;
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


             //////////////////////////////////////////// inicia piramide derecha
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
            //////////////////////////A izquierda
    new Vector2(0.161f, 0.956f), //0
    new Vector2(0.411f, 0.956f), //1
    new Vector2(0.284f, 0.787f), //2
    ///////////////////////////////// A der
     new Vector2(0.411f, 0.956f), //3
    new Vector2(0.663f, 0.956f), //4
    new Vector2(0.535f, 0.787f), //5
    /////////////////////////////////////A abjo
   new Vector2(0.284f, 0.787f), //6
    new Vector2(0.535f, 0.787f), //7
    new Vector2(0.409f, 0.614f), //8
    ////////////////////////////////A centro
    new Vector2(0.284f, 0.787f), //9
     new Vector2(0.411f, 0.956f), //10
   new Vector2(0.535f, 0.787f), //11

    /////////////////////////////////////////////incia D triangulo izquierda abajo
    new Vector2(0.014f, 0.430f), //12
    new Vector2(0.140f, 0.598f), //13
    new Vector2(0.264f, 0.430f), //14
    //////////////////////////////////////////////D arriba
     new Vector2(0.140f, 0.598f), //15
    new Vector2(0.265f, 0.768f), //16
    new Vector2(0.381f, 0.598f), //17
    //////////////////////////////////////D der abaj
    new Vector2(0.264f, 0.430f), //18
    new Vector2(0.381f, 0.598f), //19
    new Vector2(0.515f, 0.430f), //20
    ///////////////////////////////////////D centro
   new Vector2(0.140f, 0.598f), //21
    new Vector2(0.381f, 0.598f), //22
    new Vector2(0.264f, 0.430f), //23

    //////////////////////////////// C izq arriba
    new Vector2(0.052f, 0.391f), //24
    new Vector2(0.298f, 0.391f), //25
    new Vector2(0.174f, 0.220f), //26
    //////////////////////////////////////C abaj
    new Vector2(0.174f, 0.220f), //27
    new Vector2(0.426f, 0.220f), //28
    new Vector2(0.301f, 0.048f), //29
    ///////////////////////////////C der
    new Vector2(0.298f, 0.391f), //30
    new Vector2(0.550f, 0.391f), //31
     new Vector2(0.426f, 0.220f), //32
    //////////////////////////////C centro
    new Vector2(0.174f, 0.220f), //33
    new Vector2(0.298f, 0.391f), //34
     new Vector2(0.426f, 0.220f), //35


    //////////////////////////////////// punto izq abajo
    new Vector2(0.356f, 0.044f), //36
    new Vector2(0.482f, 0.212f), //37
    new Vector2(0.606f, 0.044f), //38
    ////////////////////////////////////punto arriba
    new Vector2(0.482f, 0.212f), //39
    new Vector2(0.607f, 0.383f), //40
    new Vector2(0.731f, 0.212f), //41
    /////////////////////////////////////////der abajo
    new Vector2(0.606f, 0.044f), //42
    new Vector2(0.731f, 0.212f), //43
    new Vector2(0.854f, 0.044f), //44
    //////////////////////////////////////////centro
    new Vector2(0.482f, 0.212f), //45
    new Vector2(0.731f, 0.212f), //46
    new Vector2(0.606f, 0.044f), //47


    /////////////////////////////////////////figura arriba derecha de D
    new Vector2(0.727f, 0.949f), //48
    new Vector2(0.974f, 0.949f), //49
    new Vector2(0.848f, 0.776f), //50
    /////////////////////////////////////figura D
    new Vector2(0.598f, 0.776f), //51
    new Vector2(0.727f, 0.949f), //52
    new Vector2(0.848f, 0.776f), //53
    ///////////////////////////////////figura abajo D
    new Vector2(0.598f, 0.776f), //54
     new Vector2(0.848f, 0.776f), //55
    new Vector2(0.723f, 0.606f), //56
    ////////////////////////////////////figura C
    new Vector2(0.723f, 0.606f), //57
   new Vector2(0.848f, 0.776f), //58
    new Vector2(0.973f, 0.606f), //59
    /////////////////////////////////////figura abajo C
     new Vector2(0.723f, 0.606f), //60
    new Vector2(0.973f, 0.606f), //61
    new Vector2(0.848f, 0.438f), //62
    ///////////////////////////////////////////figura A
    new Vector2(0.598f, 0.438f), //63
     new Vector2(0.723f, 0.606f), //64
    new Vector2(0.848f, 0.438f), //65
    ///////////////////////////////////////figura abajo A
    new Vector2(0.598f, 0.438f), //66
    new Vector2(0.848f, 0.438f), //67
    new Vector2(0.722f, 0.262f), //68
    //////////////////////////////////////////figura B
    new Vector2(0.722f, 0.262f), //69
    new Vector2(0.848f, 0.438f), //70
    new Vector2(0.973f, 0.262f)  //71 
    };

       

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = meshT;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }
}
