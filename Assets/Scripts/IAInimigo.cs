using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAInimigo : MonoBehaviour
{
    // Start is called before the first frame update

    private float velocidade = 6.0f;

    [SerializeField]
    private GameObject ExplosaoDoInimigo;

    private GerenciadorUI uiGerenciador;
    void Start()
    {
        uiGerenciador = GameObject.Find("Canvas").GetComponent<GerenciadorUI>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);

        if ( transform.position.y < -6.0f)
        {
            transform.position = new Vector3(17f, Random.Range(-5.7f, 5.7f), 9.9f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Tiro")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            Instantiate(ExplosaoDoInimigo, transform.position, Quaternion.identity);
            //uiGerenciador.AtualizarPlacar();
        }

        if ( other.tag =="Player")
        {
            Player player = other.GetComponent<Player>();

            if (player != null)
            {
                player.DanoAoPlayer();
            }
            Destroy(this.gameObject);

            Instantiate(ExplosaoDoInimigo, transform.position, Quaternion.identity);
        }
        
        
    }
}
