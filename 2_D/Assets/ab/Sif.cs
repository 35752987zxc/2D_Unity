using UnityEngine;

public class Sif : MonoBehaviour
{
    public bool gh;
    public int scor;
    public int combo = 1 ;
    private void Start()
    {
        if (gh)
        {
            print(222);
        }
        else
        {
            print(111);
        }

        if (scor>=60)
        {
            print("ok");
        }
        else if (scor>=40)
        {
            print("ww");
        }
        else
        {
            print("ss");

        }
        if (combo >= 150)
        {
            print("攻擊 * 10");

        }
        else if (combo >= 100)
        {
            print("攻擊 * 5");

        }
        else if (combo >= 50)
        {
            print("攻擊 * 2");
        }


    }
	
        
	
}
