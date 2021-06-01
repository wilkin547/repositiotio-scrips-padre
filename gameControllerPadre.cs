using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// el padre de los gameControllers , llevara las variables que utilizaran los gameObjects de la escena
/// </summary> <remarks>utila variables static que utilizaran varias funtes </remarks>
/// <see cref="Update">update esta como protective virtual </see>
[DisallowMultipleComponent]
public class gameControllerPadre : MonoBehaviour
{
    /// <summary>
    /// objetos que puedes uzar para ahorrar recursos
    /// </summary>
    [SerializeField]
    public GameObject[] objetos;

    [Header("UI")]
    [SerializeField]
    private GameObject gameOver, ganaste;
    private short Point = 0;
    private bool Fail;
    [SerializeField]
    private TMP_Text Score;
    /// <summary>
    /// lista de objetos para cuando tengas algun problema ;v
    /// </summary>

    [SerializeField][Range(1,60)]
    private byte fps = 30;

    [Header("move the objects")]
    /// <summary>
    /// si es verdadero movera los objetos en el eje x
    /// </summary>
    [SerializeField]
    [Tooltip("si es verdadero movera los objetos en el eje x")]
    private bool MoveX;
    /// <summary>
    /// Speed that some objects will use
    /// </summary>
    [SerializeField]
    [Range(-1000,1000)]
    [Tooltip("Speed that some objects will use")]
    private float SpeedGlobal;

protected virtual void Update()
    {
        if (Fail)
        {
            if (Input.anyKeyDown)
            {   
                SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);


            }
            
        }
        Application.targetFrameRate = fps;
    }
    /// <summary>
    /// llama al metodo al perder 
    /// </summary>
    public virtual void GameOver()
    {
        
        Fail = true;
        gameOver.SetActive(true);
        Point = 0;
    }
    /// <summary>
    /// utiliza este metodo para actualizar el marcador 
    /// </summary>
    public virtual void  UpdateScore()
    { 
        Point++;
        Score.text = "Score :" + Point;
        print(Point);
    }
    /// <summary>
    /// obten el puntaje de la partida 
    /// </summary>
    /// <returns>el valor de los puntos (short)</returns>
    public short GetPoint()
    {
        return Point;
    }
    /// <summary>
    /// obten el valor de fail
    /// </summary>
    /// <returns>devuelve si has perdido (bool)</returns>
    public bool GetBoolFail()
    {
        return Fail;
    }
    
    /// <summary>
    /// set the velocity to the objects
    /// </summary>
    /// <returns>vector3 with the velocity</returns>
    public Vector3 SetVelocity()
    {
        
        if (MoveX)
        {
            return  Vector2.right * SpeedGlobal * Time.fixedDeltaTime;
        }
        else
        {
            return Vector2.up * SpeedGlobal * Time.fixedDeltaTime;
        }

       
    }

    public delegate void UpdateScoreD();

}
