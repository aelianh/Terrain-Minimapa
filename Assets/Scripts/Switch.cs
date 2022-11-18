using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public int numero;
    public bool boleana;
    public string texto;
    // Start is called before the first frame update
    void Start()
    {
        /*if (numero == 8 && boleana == true)
        {
            Debug.Log("numero 8 y true");
        }*/
        
        switch(numero)
        {
        
            case 0:
                Debug.Log("0");
            break;
            case 1:
                Debug.Log("1");
            break;
            case 2:
                Debug.Log("2");
            break;
            case 3:
                Debug.Log("3");
            break;
            case 4:
                Debug.Log("4");
            break;
            default:
                Debug.Log("sin numero");
            break;

        }
         switch(texto)
        {
        
            case "Juan":
                Debug.Log("Hola Juan");
            break;
            case "Alberto":
                Debug.Log("Hola Alberto");
            break;
            case "Sergio":
                Debug.Log("Hola Segio");
            break;
            case "Facundo":
                Debug.Log("Hola Facundo");
            break;
            case "Teodoro":
                Debug.Log("Hola Teodoro");
            break;
            default:
                Debug.Log("sin numero");
            break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
