using UnityEngine;

public class ac : MonoBehaviour
{//地板
   // [Header("地板")]
   // [Range(0.1f,100f)]
    //[Tooltip("地板")]
   public static float floor = 4f;

    public Transform aa;


    private void Update()
   {
        Floor();

    }
    /// <summary>
    /// 地板
    /// </summary>
    private void Floor()
    {

        aa.Translate(-floor * Time.deltaTime,0,0);
    }
   
        
    

}
