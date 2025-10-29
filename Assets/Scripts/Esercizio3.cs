using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = GeneraArray(10, 1, 50);
        StampaArray(array);

        int minimo = TrovaMinimo(array);
        Debug.Log($"Il numero minore nell'array è {minimo}");

        int massimo = TrovaMassimo(array);
        Debug.Log($"Il numero maggiore nell'array è {massimo}");
    }

    int[] GeneraArray(int dimensione, int minimo, int massimo)
    {
        int[] arr = new int[dimensione];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = Random.Range(minimo,massimo + 1);
        }
        return arr;
    }

    void StampaArray(int[] array)
    {
        for(int i = 0;i < array.Length;i++)
        {
            Debug.Log(array[i]);
        }
    }

    int TrovaMinimo(int[] array)
    {
        int minimo = array[0];
        for(int i = 1; i < array.Length; i++)
        {
            if(array[i] < minimo)
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
}
