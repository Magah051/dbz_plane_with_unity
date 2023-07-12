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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Pontos();
        CriaObstaculo();
    }

    //Criando método para lidar com os pontos
    private void Pontos()
    {
        //Ganhando pontos
        pontos += Time.deltaTime;

        //Passando os meus pontos para o texto dos pontos
        pontosTexto.text = pontos.ToString();
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
