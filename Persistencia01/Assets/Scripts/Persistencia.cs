using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persistencia : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] Nomes = new string[] { "Joãozinho", "Mariazinha" };

        PlayerPrefs.SetString("Nomes", ConverterParaString(Nomes));
    
        print(ConverterParaString(Nomes));


        //string nome = PlayerPrefs.GetString("Nome");
        //int score = PlayerPrefs.GetInt("Score");

        //score++;

        //print("O Nome é:" + nome);
        //print("Score:" + score);

        //PlayerPrefs.SetString("Nome", "Joãozinho");
        //PlayerPrefs.SetInt("Score", score);
    }

    string ConverterParaString(string[] array)
    {
        string retorno = "";
        int i;

        {
            for (i = 0; i < array.Length - 1 ; i++)
            {
                retorno = retorno + array[i]+ ',';
            }
            retorno = retorno + array[i];
            return retorno;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
