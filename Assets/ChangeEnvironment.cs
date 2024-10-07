using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEnvironment : MonoBehaviour
{

    public GameObject[] _Env;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Left()
    {
        count -= 1;
        for (int x = 0; x < _Env.Length; x++)
        {
            _Env[x].SetActive(false);
        }
        _Env[count].SetActive(true);
    }
    public void Right()
    {
        count += 1;
        for (int x = 0; x< _Env.Length;x++)
        {
            _Env[x].SetActive(false);
        }
        _Env[count].SetActive(true);
    }
}
