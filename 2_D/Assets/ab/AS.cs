using UnityEngine;

public class AS : MonoBehaviour
{
    private void Test()
    {
        print("測試方法");
    }

    private int Ten()
    {
        return 10;
    }


    private string Hi()
    {
        return ("嗨");
    }


    private void Ak( int pq)
    {
        print("kkkk");
        print("jjjj");
        print("llll" + pq);
    }



    private void Start()
    {
        Test();
        int a = Ten();
        print("0000" + a);

        print("00000" + Ten());

        print("010101" + Hi());

        Ak(55);
        Ak(505);
    }
}
