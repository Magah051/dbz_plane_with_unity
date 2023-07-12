using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    //Criando as informações do Player
    //Criando as nossas variáveis
    private Rigidbody2D meuRB;
    [SerializeField] private float velocidade = 5f;

    
    // Start is called before the first frame update
    void Start()
    {
        //Pegando o meu RB sozinho
        meuRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Subindo ao apertar espaço
        Subir();
        //Limitando a minha velocidade queda
        LimitandoVelocidade();
    }

    private void LimitandoVelocidade()
    {
        if (meuRB.velocity.y < -velocidade)
        {
            //Travando meu RB.velocity.y em -5
            meuRB.velocity = Vector2.down * velocidade;
        }
    }

    //Criando o método subir
    public void Subir()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Fazendo a velocidade do RB ir para cima
            meuRB.velocity = Vector2.up * velocidade;
        }
    }

    //Configurando a colisão do Player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Usando o Scenemanager parra load a cena do Jogo.
        SceneManager.LoadScene(0);
    }
}
