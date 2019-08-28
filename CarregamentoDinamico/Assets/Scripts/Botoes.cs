using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botoes : MonoBehaviour
{
    public GameObject mSprite;

    ControleSprite cSprite;

    // Start is called before the first frame update
    void Start()
    {
        cSprite = mSprite.GetComponent<ControleSprite>();
    }

    public void AcaoBotao1()
    {
        cSprite.TrocaTextura("img1");
    }

    public void AcaoBotao2()
    {
        cSprite.TrocaTextura("img2");
    }
}

