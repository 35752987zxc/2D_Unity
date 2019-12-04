using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    public Text textScore;
    public Text textop;


    /// <summary>
    /// 加分
    /// </summary>
    /// <param name="add">添加為1</param>
    public void ass( int add = 1)
    {
        fraction = fraction + add;
        textScore.text = fraction.ToString();

        opt();
    }
    /// <summary>
    /// 最佳
    /// </summary>
    public void opt()
    {
        if (fraction > optimal)
        {
            PlayerPrefs.SetInt("最佳", fraction);
        }
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
    /// 重來
    /// </summary>
    public void repaly()
    {
        SceneManager.LoadScene("遊戲場景");
    }
    /// <summary>
    /// 離開
    /// </summary>
    public void exit()
    {
        Application.Quit();
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
        optimal = PlayerPrefs.GetInt("最佳");

        textop.text = optimal.ToString();


    }
}
