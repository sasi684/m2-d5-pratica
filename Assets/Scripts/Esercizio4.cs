using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{

    [SerializeField] private int dimensione, minimoRandom, massimoRandom;

    // Start is called before the first frame update
    void Start()
    {
        int[] array = GeneraArray(dimensione, minimoRandom, massimoRandom);
        StampaArray(array);

        int minimo = TrovaMinimo(array);
        Debug.Log($"Il numero minore nell'array è {minimo}");

        int massimo = TrovaMassimo(array);
        Debug.Log($"Il numero maggiore nell'array è {massimo}");

        TrovaMinimi2(array);
        TrovaMassimi2(array);
    }

    int[] GeneraArray(int dimensione, int minimo, int massimo)
    {
        int[] arr = new int[dimensione];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Random.Range(minimo, massimo + 1);
        }
        return arr;
    }

    void StampaArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
    }

    int TrovaMinimo(int[] array)
    {
        int minimo = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minimo)
                minimo = array[i];
        }
        return minimo;
    }

    int TrovaMassimo(int[] array)
    {
        int massimo = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > massimo)
                massimo = array[i];
        }
        return massimo;
    }

    void TrovaMinimi2(int[] array)
    {
        int min1 = array[0];
        int min2 = min1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min1)
                min1 = array[i];
        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min2 && array[i] != min1)
                min2 = array[i];
        }

        Debug.Log(min1 + " " + min2);
    }

    void TrovaMassimi2(int[] array)
    {
        int max1 = array[0];
        int max2 = max1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max1)
                max1 = array[i];
        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max2 && array[i] != max1)
                max2 = array[i];
        }

        Debug.Log(max1 + " " + max2);
    }
}
