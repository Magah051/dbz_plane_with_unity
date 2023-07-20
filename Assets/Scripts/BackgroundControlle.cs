using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControlle : MonoBehaviour
{
    //Pegando o meu material
    private Renderer meuFundo;
    //Posição do meu X offset
    private float xOffset = 0f;
    //Posição da minha texturra
    private Vector2 texturaOffset;
    //Velocidade
    [SerializeReference] private float velocidade = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        //Pegando o meu fundo
        meuFundo = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Diminuido o valor do meu xOffset
        xOffset += Time.deltaTime * velocidade;
        
        //Passando o xOffset para o eixo x da minha textua
        texturaOffset.x = xOffset;

        //Movendo o offset x do meu renderer
        meuFundo.material.mainTextureOffset = texturaOffset;
    }
}
