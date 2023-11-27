using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDeObjetos : MonoBehaviour
{

    [SerializeField]
    private GameObject inimigoPrefab ;

    [SerializeField]
    private GameObject [] powerUps ;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RotinaGeracaoInimigo());
        StartCoroutine(RotinaGeracaoPowerUp());
    }

    IEnumerator RotinaGeracaoInimigo()
    {
        while ( 1==1 )
        {
            Instantiate(inimigoPrefab, new Vector3(38.8f, Random.Range(-7.9f, 8.21f),0), Quaternion.identity);
            yield return new WaitForSeconds(6);  
        }
    }
        IEnumerator RotinaGeracaoPowerUp() 
    {
        while ( 1==1 ) 
        {
            int powerUpsAletatorio = Random.Range(0, 3);
            Instantiate(powerUps[powerUpsAletatorio], new Vector3(38.8f, Random.Range(-7.9f, 8.21f), 0), Quaternion.identity);
            yield return new WaitForSeconds(6);
        }
        /*
        E porque estamos usando valores de 0 a 3 se o �ndice do array vai de 0 a
           2? Eu explico. Quando se trabalha com valores inteiros no Random.Range,
           ele sempre ir� retornar� um valor inteiro aleat�rio entre o m�nimo e o
           m�ximo exclusivo, o que significa que se coloc�ssemos como range os
valores (0, 2) a vari�vel powerUpsAleatorio s� receberia os valores 0 e 1.  
Por essa raz�o inserimos o valor m�nimo 0 e o m�ximo 3, dessa forma,
iremos obter ou valor 0 ou 1 ou 2, e esses valores se encaixam perfeitamente
nos valores do �ndice do array.
         */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
