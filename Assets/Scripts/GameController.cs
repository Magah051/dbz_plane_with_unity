using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //Timer
    [SerializeField] private float timer = 1f;
    //Meu obstáculo
    [SerializeField] private GameObject obstaculo;
    //Posição para criar o obstáculo
    [SerializeField] private Vector3 posicao;
    //Posicao mínima e máxima
    [SerializeField] private float posMin = - 0.3f;
    [SerializeField] private float posMax = 2.4f;

    //Tempo mínimo e máximo
    [SerializeField] private float tMin = 1f;
    [SerializeField] private float tMax = 3f;

    //Variavel dos pontos
    private float pontos = 0f;

    //Variável dos pontos do canvasa
    [SerializeField] private Text pontosTexto;

    //Variável do Level
    [SerializeField] private Text levelTexto;

    //Variável do level
    private int level  = 1;

    //Varriável para ganhar level
    [SerializeField] private float proximoLevel = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Pontos();
        CriaObstaculo();
        GanhaLevel();
    }

    //Criando método para lidar com os pontos
    private void Pontos()
    {
        //Ganhando pontos
        pontos += Time.deltaTime;

        //Passando os meus pontos para o texto dos pontos
        pontosTexto.text = Mathf.Round(pontos).ToString();
    }

    //Ganhando Level
    private void GanhaLevel()
    {
        //Passando o level para o texto do level

        levelTexto.text = level.ToString();

        //Se os pontos forem maiores que o próximo level, então eu aumento o valor do level e dobro a quantidade de pontos para o próximo level
        if (pontos > proximoLevel)
        {
            //Aumentando o level em um e dobrando o valor do próximo level
            level++;
            proximoLevel *= 2;
        }
    }

    private void CriaObstaculo()
    {
        //Criando obstaculos
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            //Timer com valor aleatório entre 1f e 3f
            timer = Random.Range(tMax, tMax);

            posicao.y = Random.Range(posMin, posMax);

            //Obstaculos
            Instantiate(obstaculo, posicao, Quaternion.identity);//Deixar como está quaternion (aula 127)
        }
    }
}
