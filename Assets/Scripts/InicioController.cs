using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Checar se espa�o est� sendo pressionado
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Carregando oa cena do jogo
            SceneManager.LoadScene(1);
        }
    }
}
