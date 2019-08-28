using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleSprite : MonoBehaviour
{
    Texture2D textura;

    // Start is called before the first frame update
    void Start()
    {
        TrocaTextura("img1");
    }

    public void TrocaTextura (string img)
    {
        textura = Resources.Load<Texture2D>(img);
        Sprite sprite = Sprite.Create(textura, new Rect(0, 0, textura.width, textura.height), new Vector2(0.5f, 0.5f));

        GetComponent<SpriteRenderer>().sprite = sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
