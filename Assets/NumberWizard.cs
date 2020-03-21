using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Bienvenido al Number Wizard!");
        Debug.Log("Elige un número, no me digas cuál es...");
        Debug.Log("El nº más alto que puedes elegir es: " + max);
        Debug.Log("El nº más bajo que puedes elegir es: " + min);
        Debug.Log("Dime si el número es más alto o más bajo de " + guess);
        Debug.Log("Arriba = Más alto, Abajo = Más bajo, Enter = Correcto");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("\n----------------------- ¡ Soy un genio ! -----------------------\n");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Dime si el número es más alto o más bajo de " + guess);
    }
}
