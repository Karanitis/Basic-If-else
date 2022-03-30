using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicIfElse : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

            TemperatureTest();
            coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    { // Kahvenin sýcaklýðý en sýcak içme sýcaklýðýndan büyükse...
        if (coffeeTemperature > hotLimitTemperature)

        {
            Debug.Log("Kahve Cok sicak");

        }
        else if (coffeeTemperature < coldLimitTemperature)
        {
            Debug.Log("Kahve Cok soguk");
        }
        else
        {
            Debug.Log("Bu kahve Harika");
        }
    }
}