using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M1 : MonoBehaviour
{
    string parte1, parte2;

    // Start is called before the first frame update
    void Start()
    {
        parte1 = "meu";
        parte2 = "Metodo";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Invoke(parte1 + parte2, 0); //( , delay pra executar a ação)
    }

    void meuMetodo()
    {
        transform.Translate(0, 1, 0);
    }
}
