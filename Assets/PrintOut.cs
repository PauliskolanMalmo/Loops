﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintOut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            if (i < 10)
            {
                print(i);
            }

            if (i > 9 && i < 21)
            {
                if (i % 2 == 0)
                {
                    print(i);
                }
            }

            else if (i > 20)
            {

                if (i % 2 == 1)
                {
                    print(i);
                }
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
