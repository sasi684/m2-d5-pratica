using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = GeneraArray(10, 1, 100);
        Debug.Log("Di seguito l'array iniziale:");
        StampaArray(array);

        array = CambiaDimensioneArray(array, 5);
        Debug.Log("Di seguito l'array più piccolo:");
        StampaArray(array);

        array = GeneraArray(10, 1, 100);
        Debug.Log("Di seguito l'array iniziale:");
        StampaArray(array);

        array = CambiaDimensioneArray(array, 13);
        Debug.Log("Di seguito l'array più grande:");
        StampaArray(array);

        array = GeneraArray(10, 1, 100);
        Debug.Log("Di seguito l'array iniziale:");
        StampaArray(array);

        array = CambiaDimensioneArray(array, 10);
        Debug.Log("Di seguito l'array uguale:");
        StampaArray(array);
    }

    // Update is called once per frame
    void Update()
    {
        
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

    int[] CambiaDimensioneArray(int[] array, int dim)
    {
        int[] newArray;

        if (dim < array.Length)
        {
            newArray = new int[dim];
            for (int i = 0; i < dim; i++)
            {
                newArray[i] = array[i];
            }
        }
        else if (dim > array.Length)
        {
            newArray = new int[dim];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
        }
        else
            return array;

        return newArray;
    }
}
