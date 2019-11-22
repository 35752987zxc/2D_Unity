using UnityEngine;

public class Asd : MonoBehaviour
{
    public int a = 10, b = 3;

    private void Start()
    {
        #region

        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);
        a = a + 1;
        print(a);
        print(a++);
        print(++a);
        a = a + 10;
        a += 10;

        #endregion


        #region
        print(a > b);
        print(a < b);
        print(a >= b);
        print(a <= b);
        print(a == b);
        print(a != b);
        #endregion
        #region
        print(true && false);  
        print(true || false);


        #endregion






    }

}
