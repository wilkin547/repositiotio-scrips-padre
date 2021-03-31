using UnityEngine;

public class setFrameVelocity : MonoBehaviour
{

    void Update()
    {
        Application.targetFrameRate = 60;
        /*if (!Input.anyKey)
        {
            Invoke("UpdateTargetFrameRate", 5);
        }*/
    }

    private void UpdateTargetFrameRate()
    {
        CancelInvoke("UpdateTargetFrameRate");
        Application.targetFrameRate = 5;
    }
}
