using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class M2 : MonoBehaviour
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
        //StartCoroutine(parte1 + parte2, 1f);
        MethodInfo metodo = this.GetType().GetMethod(parte1 + parte2, BindingFlags.NonPublic|BindingFlags.Instance);
        metodo.Invoke(this, new object[] { 1f ,-.1f,"teste"});
    }

    string meuMetodo(float x, float y, string txt)
    {
        transform.Translate(x, y, 0);
        return "funcionou" + txt;
    }
}
