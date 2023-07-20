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
        //Morrendo ao sai da tela po cima ou por baixo
        MorrendoAoSair();
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

    //Reiniciando ao sair da tela
    private void MorrendoAoSair()
    {
        //Checando se eu sai da tela
        if (transform.position.y > 5.5f|| transform.position.y < -5.5f)
        {
            //Reiniciando o jogo
            SceneManager.LoadScene(0);
        }
    }

    //Configurando a colisão do Player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Usando o Scenemanager parra load a cena do Jogo.
        SceneManager.LoadScene(0);
    }
}
