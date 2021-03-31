using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

[DisallowMultipleComponent]


public class GameController : MonoBehaviour
{
    public static GameController instancia;
    [Header("Variables")]
    
    [HideInInspector]
    public float timeCurrent;
    public float TimeWait = 1.5f; //hago las variables publicas para reutilizarlas en la creacion de sprites
    [Range(0,100)]
    public float velozidad = 5f;
    [HideInInspector]
    public float? placePlay = 2.5f;
    [HideInInspector]
    public bool enjuego;
    [HideInInspector]
    public bool perdiste;
    [HideInInspector]
    public bool pp;
    [HideInInspector]
    public short puntos = 0;
    [Space(5)]
    [Header("GameObjects Variables")]
    [Space(5)]
    public TMP_Text Scoree;
    public GameObject[] sprite;
    public GameObject player;
    public GameObject GameOver;
    public GameObject particula;



    private void Awake()
    {
        GameController.instancia = this;
        GameController.instancia.enjuego = false;
        switch (SceneManager.GetActiveScene().name)
        {
            case "nivel 2":
                particula = null;
                break;   
        }

    }

    private void Update()
    {
        bool face = true;
        if (face&&Input.anyKey)
        {
            face = false;
            GameController.instancia.enjuego = true;
        }

        if (!GameController.instancia.enjuego)
        {
            return;
        }

        GameController.instancia.timeCurrent += Time.deltaTime;
        GameController.instancia.pp = false;
        if (GameController.instancia.timeCurrent >= GameController.instancia.TimeWait)
        {
            GameController.instancia.pp = true;
            GameController.instancia.timeCurrent -= GameController.instancia.TimeWait;

        }

        if (GameController.instancia.perdiste && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void actualizar_marcador()
    {
        GameController.instancia.puntos++;
        GameController.instancia.Scoree.text ="score" + GameController.instancia.puntos;
    }
    public void Game_Over()
    {
        GameController.instancia.GameOver.SetActive(true);
        GameController.instancia.enjuego = false;
        GameController.instancia.perdiste = true;

        for (int i = 0; i < GameController.instancia.sprite.Length; i++)
        {
            GameController.instancia.sprite[i].transform.localScale = new Vector2(1, 1);
        }

    }




}
