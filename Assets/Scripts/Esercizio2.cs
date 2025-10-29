using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{

    [SerializeField] private int num1, num2, num3;

    // Start is called before the first frame update
    void Start()
    {
        if (IsEven(num1))
            Debug.Log($"Il numero {num1} è pari");
        else
            Debug.Log($"Il numero {num1} è dispari");

        if (IsMultipleOf(num2, num3))
            Debug.Log($"Il numero {num2} è multiplo di {num3}");
        else
            Debug.Log($"Il numero {num2} NON è multiplo di {num3}");
    }

    bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    bool IsMultipleOf(int multiple, int baseNumber)
    {
        if( multiple == 0 )
            return false;

        return multiple % baseNumber == 0;
    }
}
