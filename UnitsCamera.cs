using UnityEngine;

public class UnitsCamera : MonoBehaviour
{


    public  float NumberToReScaler = 1;


    float[] porcentajes = new float[6];



    void Start()
    {     
        
       float[] lista = new float[6];
       float[] lista1 = new float[6];
      


        lista[0] = 0.8606873f;
        lista[1] = 0.7961357f;
        lista[2] = 0.7961357f;
        lista[3] = 0.7088096f;
        lista[4] = 0.7974108f;
        lista[5] = 0.6977345f;

        lista1[0] = 480 + 800;
        lista1[1] = 720 + 1280;
        lista1[2] = 1080 + 1920;
        lista1[3] = 1080 + 2160;
        lista1[4] = 1440 + 2560;
        lista1[5] = 1440 + 2960;



        for (int i = 0; i < lista.Length; i++)
        {
            porcentajes[i] = lista[i] / lista[1];
        }

        for (int i = 0; i < lista.Length; i++)
        {
            lista[i] *= porcentajes[i];
        }   
        



        Camera mj_camera = Camera.main;

        float m = mj_camera.pixelWidth + mj_camera.pixelHeight;

        int e = 0;

        while(e <= 5)
        {
            if (m == lista1[e])
            {
                Debug.Log(porcentajes[e]);
                NumberToReScaler = porcentajes[e];
                transform.localScale = new Vector2(transform.localScale.x * NumberToReScaler, transform.localScale.y);
                return;
            }
            else
            {
                NumberToReScaler = 1;
            }
            e++;
        }

    }
    private float conseguirPorcentaje (float value)
    {
        return value;
    }

}
