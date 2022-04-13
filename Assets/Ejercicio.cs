using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{
    public string codigoAnimal = "Ingrese el código del animal";
    public int diasEstancia;
    // Start is called before the first frame update
    void Start()
    {
        int gramosGatos = 300;
        int gramosPerros = 400;
        int gramosPerrosGrandes = 700;
        float costoGatos = gramosGatos * diasEstancia / 100 * 80;
        float costoPerros = gramosPerros * diasEstancia / 100 * 80;
        float costoPerrosGrandes = gramosPerrosGrandes * diasEstancia / 100 * 80;

        if (diasEstancia < 3)
        {
            Debug.Log("Error. Ingrese una cantidad de días mayor");
        }
        else
        {
            switch (codigoAnimal)
            {
                case "G":
                    Debug.Log("Para ese período se necesitan " + gramosGatos * diasEstancia + " gramos de alimento");
                    Debug.Log("El costo para dicha cantidad de alimento es de $" + costoGatos);
                    break;
                case "PP":
                    Debug.Log("Para ese período se necesitan " + gramosPerros * diasEstancia + " gramos de alimento");
                    Debug.Log("El costo para dicha cantidad de alimento es de $" + costoPerros);
                    break;
                case "PG":
                    Debug.Log("Para ese período se necesitan " + gramosPerrosGrandes * diasEstancia + " gramos de alimento");
                    Debug.Log("El costo para dicha cantidad de alimento es de $" + costoPerrosGrandes);
                    break;
                default:
                    Debug.Log("Error. Ingrese un código válido");
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
