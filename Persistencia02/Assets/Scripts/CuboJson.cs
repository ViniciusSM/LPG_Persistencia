using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class CuboJson : MonoBehaviour
{
    public Vector3 posicao;

    public string nome;
    string json;
    

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey(gameObject.name))
        {
            json = PlayerPrefs.GetString(gameObject.name);
            JsonUtility.FromJsonOverwrite(json, this);

            posicao = transform.position;
            nome = gameObject.name;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        { transform.Translate(0, .1f, 0); }

        if (Input.GetKey(KeyCode.DownArrow))
        { transform.Translate(0, -.1f, 0); }
        
    }

    private void OnMouseDown()
    {
        if (Input.GetKey(KeyCode.S)) //Salvar Posição
        {
            posicao = transform.position;
            nome = gameObject.name;
            json = JsonUtility.ToJson(this);
            PlayerPrefs.SetString(nome, json);
        }

        else if (Input.GetKey(KeyCode.C)) //Carregar Posição
        {
            JsonUtility.FromJsonOverwrite(json, this);
            transform.position = posicao;
            gameObject.name = nome;
        }
    }
}
