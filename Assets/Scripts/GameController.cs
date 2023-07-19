using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //Timer
    [SerializeField] private float timer = 1f;
    //Meu obst�culo
    [SerializeField] private GameObject obstaculo;
    //Posi��o para criar o obst�culo
    [SerializeField] private Vector3 posicao;
    //Posicao m�nima e m�xima
    [SerializeField] private float posMin = - 0.3f;
    [SerializeField] private float posMax = 2.4f;

    //Tempo m�nimo e m�ximo
    [SerializeField] private float tMin = 1f;
    [SerializeField] private float tMax = 3f;

    //Variavel dos pontos
    private float pontos = 0f;

    //Vari�vel dos pontos do canvasa
    [SerializeField] private Text pontosTexto;

    //Vari�vel do Level
    [SerializeField] private Text levelTexto;

    //Vari�vel do level
    private int level  = 1;

    //Varri�vel para ganhar level
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

    //Criando m�todo para lidar com os pontos
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

        //Se os pontos forem maiores que o pr�ximo level, ent�o eu aumento o valor do level e dobro a quantidade de pontos para o pr�ximo level
        if (pontos > proximoLevel)
        {
            //Aumentando o level em um e dobrando o valor do pr�ximo level
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
            //Timer com valor aleat�rio entre 1f e 3f
            timer = Random.Range(tMax, tMax);

            posicao.y = Random.Range(posMin, posMax);

            //Obstaculos
            Instantiate(obstaculo, posicao, Quaternion.identity);//Deixar como est� quaternion (aula 127)
        }
    }
}
