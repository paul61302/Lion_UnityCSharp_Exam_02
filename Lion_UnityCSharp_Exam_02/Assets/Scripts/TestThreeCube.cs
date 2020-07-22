using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestThreeCube : MonoBehaviour
{
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        CubeA();
    }

    public void CubeA()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Instantiate(cube, new Vector3(i,j,0),Quaternion.identity);
            }
        }

        for (int i = 9; i < 10; i--)
        {
            for (int j = 8; j < i; j--)
            {
                Instantiate(cube, new Vector3(i+10, j+10, 0), Quaternion.identity);
            }
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Instantiate(cube, new Vector3(i, j, 0), Quaternion.identity);
            }
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Instantiate(cube, new Vector3(i, j, 0), Quaternion.identity);
            }
        }
    }
}
