using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDoJogo : MonoBehaviour
{
    public bool fimDeJogo = true;
    // Start is called before the first frame update

    public GameObject player;

    private GerenciadorUI gerenciadorUI;

    void Start()
    {
        gerenciadorUI = GameObject.Find("Canvas").GetComponent<GerenciadorUI>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if ( Input.GetKeyDown(KeyCode.Space) )
        {
            Instantiate(player,Vector3.zero, Quaternion.identity);

            fimDeJogo = false;

            gerenciadorUI.EsconderTelaInicial();
        }
    }

    public void EncerrarJogo()
    {
        fimDeJogo = true;

        gerenciadorUI.MostrarTelaInicial();
    }*/
    }
}