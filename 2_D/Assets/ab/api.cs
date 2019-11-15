using UnityEngine;

public class api : MonoBehaviour
{
    public Ad ad;


    private void Start()
    {
        ad.Jumpheight = 999;

        print("小雞跳躍欄位" + ad.Jumpheight);
    }
}
