using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciadorUI : MonoBehaviour
{
    public Sprite[] vidas;
    public Image mostrarImagemDasVidas;

    //private int placar = 0;

    public Text textoDoPlacar;

    public GameObject tituloDaTela;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AtualizarVidas(int vidasAtuais)
    {
        mostrarImagemDasVidas.sprite = vidas[vidasAtuais];

    }
}
