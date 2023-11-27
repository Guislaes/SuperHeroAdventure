using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public float velocidade = 0.0f;
    public float entradaHorizontal;
    public float entradaVertical;

    public GameObject pfLaser;

    public float tempoDeDisparo = 0.3f;
    public float podeDisparar = 0.0f;

    public bool possoDarDisparoTriplo = false;

    public GameObject disparoTriplo;

    public int vidas = 3;

    private GerenciadorUI uiGerenciador;

    private GerenciadorDoJogo GerenciadorDoJogo;

    [SerializeField]
    private GameObject explosaoPlayerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start de " + this.name);
        velocidade = 3.0f;
        transform.position = new Vector3(0, 0, 0);

        uiGerenciador = GameObject.Find("Canvas").GetComponent<GerenciadorUI>();
        if (uiGerenciador != null)
        {
            Debug.Log("2");
            uiGerenciador.AtualizarVidas(vidas);

        }





    }
// Update is called once per frame
void Update()
    {
        Movimento();
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Disparo();
        }
    }
    private void Movimento()
    {
        float entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * entradaHorizontal * Time.deltaTime * velocidade);
        if (transform.position.y > 4.75f)
        {
            transform.position = new Vector3(transform.position.x, 4.75f, 0);
        }
        else if (transform.position.y < -4.75f)
        {
            transform.position = new Vector3(transform.position.x, -4.75f, 0);
        }
        float entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * entradaVertical * Time.deltaTime * velocidade);
        if (transform.position.x > 9.90f)
        {
            transform.position = new Vector3(9.90f, transform.position.y, 0);
        }
        else if (transform.position.x < -9.90f)
        {
            transform.position = new Vector3(-9.90f, transform.position.y, 0);
        }
    }
    public bool DarDisparoTriplo = false;
    [SerializeField]
    private GameObject _disparoTriploPrefab;

    private void Disparo()
    {
        if (Time.time > podeDisparar)
        {

            if (possoDarDisparoTriplo == true)
            {
                Instantiate(disparoTriplo, transform.position, Quaternion.identity);
            }
            else
            {
                Instantiate(pfLaser, transform.position + new Vector3(1.1f, 0, 0), Quaternion.identity);
            }

            podeDisparar = Time.time + tempoDeDisparo;

        }

    }

    public void LigarPUDisparoTriplo()
    {
        possoDarDisparoTriplo = true;

        StartCoroutine(DisparoTriploRotina());
    }

    public IEnumerator DisparoTriploRotina() {
        yield return new WaitForSeconds(7.0f);
        possoDarDisparoTriplo = false;
    
    }

    public void DanoAoPlayer()
    {
        // vidas = vidas - 1;
        vidas--;
        uiGerenciador.AtualizarVidas(vidas);
        if (vidas < 1 )
        {
            Instantiate(explosaoPlayerPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
                                        
    
   

    



















}   