using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hensuu : MonoBehaviour
{
    int a = 10;
    int vx = 20;

    public void Ensyu71()
    {
        int vx = 5;
        Debug.Log(vx);

        vx = 10;
        Debug.Log(vx);
    }

    public void Ensyu72()
    {
        Debug.Log(vx);
    }

    public void Ensyu74()
    {
        vx += 10;
        Debug.Log(vx); 
    }


    // Start is called before the first frame update
    public void Proc()
    {
        
        float fw = 3.14f;
        string str = "こんにちは";
        bool bl = true;

        Debug.Log(a+a);
        Debug.Log(fw);
        Debug.Log(str);
        Debug.Log(bl);
    }

    public void Proc2()
    {
        Debug.Log(a);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
