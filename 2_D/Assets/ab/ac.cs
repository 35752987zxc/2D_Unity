using UnityEngine;

public class ac : MonoBehaviour
{//地板
    [Header("地板")]
    [Range(0.1f,100f)]
    [Tooltip("地板")]
   public float floor = 1.5f;

    public Transform aa;


    private void Update()
   {

        aa.Translate(-floor,0,0);

    }
    /// <summary>
    /// 地板
    /// </summary>
    private void Floor()
    {

    }
   
        
    

}
