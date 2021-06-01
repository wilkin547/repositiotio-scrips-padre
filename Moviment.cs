using UnityEngine;
/// <summary>
/// scrip padre para mover un gameObject <para></para>
/// tiene los metodos "reStar"<see cref="ReStar"/> y "SetVlocity"<see cref="Setvelocity"/>
/// 
/// </summary><remarks> utilizalo con el gameController corespondiente <see cref="gameControllerPadre"/></remarks>
///<inheritdoc/>
[RequireComponent(typeof(Rigidbody2D))]


public class Moviment : MonoBehaviour 
{
    
    protected RectTransform rectTransform;
    protected new Rigidbody2D rigidbody2D;
    

     protected virtual void Start()
    {   
        rectTransform = GetComponent<RectTransform>();
        rigidbody2D = GetComponent<Rigidbody2D>();
      
    }



     protected virtual void Update()
    {
        Setvelocity();
    }
/// <summary>
/// remeber , you need to make a limits , which the tag is "Finish"
/// </summary>
/// <param name="collision"></param>
     protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        ReStar();
    }
    /// <summary>
    /// use this when you object come to the limits
    /// </summary>
    protected virtual void ReStar()
    { 
    }

    /// <summary>
    /// this metho is called in update and set the velocity 
    /// </summary>
    protected virtual void Setvelocity()
    {
    }



    

}
