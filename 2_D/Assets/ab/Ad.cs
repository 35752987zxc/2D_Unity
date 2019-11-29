using UnityEngine;

public class Ad : MonoBehaviour
{   //小雞
    [Header("跳躍高度")]
    [Range(1,5000)]
    [Tooltip("跳躍高度")]
    public int Jumpheight = 100;
    [Header("角度")]
    public float asd = 5;
    [Header("是否死亡")]
    [Tooltip("是否死亡")]
    public bool Whetheritisdead;

    public GameObject gozp, gogm;

    public Rigidbody2D R2d;

    public GM gm;
    [Header("音效")]
    public AudioSource aud;
    public AudioClip wul;
    public AudioClip n3;
    public AudioClip j;

    private void Update()
    {
        jump();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // print(collision.gameObject.name);
        whd();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "04_水管"|| collision.gameObject.name == "04_水管 (1)")
        {
            whd();
            
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "通過")
        {

            gm.opt();
            gjo();
        }
    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void jump()
    {

        if (Whetheritisdead) return;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            gozp.SetActive(true);
            gogm.SetActive(true);
            R2d.Sleep();
            R2d.gravityScale = 1.5f;
            R2d.AddForce(new Vector2 (0, Jumpheight));
            aud.PlayOneShot(wul);
        }
        R2d.SetRotation(asd * R2d.velocity.y);
    }
    /// <summary>
    /// 死亡
    /// </summary>
    private void whd()
    {
        Whetheritisdead = true;
        gm.gg();
        ac.floor = 0;
        aud.PlayOneShot(n3);

    }
    /// <summary>
    /// 水管
    /// </summary>
    private void gjo( )
    {
        aud.PlayOneShot(j);
    }
}
