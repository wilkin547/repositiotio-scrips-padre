using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class PadreGameController : MonoBehaviour
{

    public static PadreGameController padreGameController;


    [SerializeField]
    private float limitsX;
    [SerializeField]
    private float limitsY;

    [SerializeField]
    [Tooltip("las posiciones aleatorias para reutilizar los objetos ")]
    private Transform[] PositiosRespanw;
    [SerializeField]
    private bool Active60Frames;

    private short Points;

    private bool fail;
    public bool Fail => fail;

    [SerializeField]
    [Range(0, 1000)]
    private float speed;
    public float Speed => speed;

    [SerializeField]
    private TMP_Text Score;
    [SerializeField]
    private GameObject gameOver;


    virtual public void UpdateScore()
    {
        Points++;
        Score.text = "Score: " + Points;
    }

    public void GameOver()
    {
        fail = true;
        gameOver.SetActive(true);
    }
 
    float ii = 0;
    virtual public void Update()
    {

            if (Active60Frames)
            {
                Application.targetFrameRate = 60;
            }
            else
            {
                Application.targetFrameRate = 30;
            }

            if (Fail)
            {
            
                ii += Time.deltaTime;
                if (ii > 0.5f && Input.anyKey)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
                }

            }

            if(Points%5 == 1)
        {
            speed += 10;
        }
       
    }
   
    /// <summary></summary>
    /// <returns><para>El limite en el eje X</para><para>Que se utilizara en el objeto "mover"</para> </returns>
    public float GetLimitsX()
    {
        return limitsX;
    }
    /// <summary></summary>
    /// <returns><para>El limite en el eje Y</para><para>Que se utilizara en el objeto "mover"</para> </returns>
    public float getLimitsY()
    {
        return limitsY;
    }
     /// <summary>
     /// caundo tengas varios objetos en movimiento , sera mejor reutilizarlos asi que esto te dara una posicion a la zar
     /// </summary>
     /// <returns>un vector2 aleatoreo </returns>
    public Vector2 GetRamdomPosition()
    {
        return PositiosRespanw[Random.Range(0, PositiosRespanw.Length -1)].position;
    }

    

}
