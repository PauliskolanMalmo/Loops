using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public int speed;
    public int maxSpeed;

    void Start()
    {
        maxSpeed = Random.Range(60, 120);
        StartCoroutine(speedRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator speedRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            speed += 5;

            if (speed > maxSpeed)
            {
                break;
            }

        }
    }
}