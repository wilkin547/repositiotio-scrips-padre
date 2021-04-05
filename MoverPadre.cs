using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]

public class MoverPadre : MonoBehaviour
{

    private float Speed;
    private float Limit;

    private Rigidbody2D rigidbody2;
    private  Vector2 vector2;
    
    public PadreGameController gameController1;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="speed">la velozidad a la que se movera</param>
    /// <param name="limit">limite de la posicion</param>
    /// <param name="gameObject">es este gameObject</param>
    /// <param name="vector">limite de la posicion </param>

    // metodos para moverlos en partes especificos 
    public void Mover_Derecho()
    {
        rigidbody2.velocity = Vector2.right * Speed * Time.deltaTime;

        if (transform.position.x >= Limit)
        {
            Reinicio(gameController1);
            transform.position = vector2;
        }
        
    }
    public void Mover_izquierda()
    {
        rigidbody2.velocity = Vector2.left * Speed * Time.deltaTime;
        if (transform.position.x <= Limit)
        {
            Reinicio(gameController1);
            transform.position = vector2;
        }
    }
    public void Mover_Arriba()
    {
        rigidbody2.velocity = Vector2.up * Speed * Time.deltaTime;
        if (transform.position.y >= Limit)
        {
            Reinicio(gameController1);
            transform.position = vector2;
        }
    }
    public void Mover_Abajo()
    {
        rigidbody2.velocity = Vector2.down * Speed * Time.deltaTime;
        if (transform.position.y <= Limit)
        {
            Reinicio(gameController1);
            transform.position = vector2;
        }
    }
  

    /// <summary>
    /// agregale el padreGamecontroller y modifica el parametro para que llame el metodo "UpdateScore"
    /// </summary>
    /// <param name="gameController">gamecontroller</param>
    virtual public void Reinicio (PadreGameController gameController){
       
        }


    public void SetSpeed(float a)
    {
        Speed = a;
    }
    public void SetLimits(float b)
    {
        Limit = b;
    }
   public void SetVector(Vector2 vec)
    {
        vector2 = vec;
    }

    public void setRigibody(Rigidbody2D rigidbody2D)
    {
        rigidbody2 = rigidbody2D;
    }
}