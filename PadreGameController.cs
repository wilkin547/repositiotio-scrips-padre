using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class PadreGameController : MonoBehaviour
{
    [SerializeField]
    private bool Active60Frames;
    private short points;
    public short Points => points;

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
        points++;
        Score.text = "Score: " + Points;
    }

    public void GameOver()
    {
        fail = true;
        gameOver.SetActive(true);
    }


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
        
        if (Fail && Input.anyKey)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        }
       
    }


}
