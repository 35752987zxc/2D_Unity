using UnityEngine;

public class GM : MonoBehaviour
{   //GM
    [Header("分數")]
    public int fraction;
    [Header("最佳")]
    public int optimal;
    [Header("水管")]
    public GameObject pipe;
    [Header("結束")]
    public GameObject g;


    /// <summary>
    /// 加分
    /// </summary>
    /// <param name="add">添加為1</param>
    private void aS( int add = 1)
    {

    }
    /// <summary>
    /// 最佳
    /// </summary>
    public void opt()
    {
        print("1");
    }
    /// <summary>
    /// 結束
    /// </summary>
    public void gg()
    {
        g.SetActive(true);
        CancelInvoke("spawnpipe");
        
    }
    /// <summary>
    /// 水管
    /// </summary>
    private void spawnpipe()
    {
        Vector3 ss = new Vector3 (5, Random.Range(-1.7f,2f), 0);
        Object.Instantiate(pipe,ss,Quaternion.identity); 
    }

    private void Start()
    {

        // spawnpipe();
        InvokeRepeating("spawnpipe", 0, 1.5f);


    }
}
