using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    int initX = -5;
    int initY = 0;
    [SerializeField]
    Transform cube;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0;i<10;i++)
        {
            for(int j = 0; j < 10; j++)
            {
                Transform instance = Instantiate(cube);
                instance.localPosition = new Vector3(initX + i, initY+j, 5);
            }

        }
    }


}
