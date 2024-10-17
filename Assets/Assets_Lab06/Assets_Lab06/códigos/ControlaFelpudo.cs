using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlaFelpudo : MonoBehaviour
{
    
    public Rigidbody2D corpo;
    public GameObject posicaorenascer;
    public float velocidade = 5f;
    public float forcapulo =64f;
    private float contagempulo = 0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame

    void Update()
    {
        Pulo();
    }
    void FixedUpdate()
    {
        Vector3 moveplayer = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += moveplayer* velocidade*Time.deltaTime;
    }

    void Pulo()
    {
        if(Input.GetButtonDown("Jump")&&contagempulo==0)
        {
            corpo.AddForce(new Vector2(0f, forcapulo),ForceMode2D.Impulse);
            contagempulo++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "chao")
        {
            contagempulo = 0;
        }
        else if(collision.gameObject.tag == "morte")
        {
             transform.position = posicaorenascer.transform.position;
        }
        else if (collision.gameObject.tag == "fofura")
        {
            SceneManager.LoadScene("final feliz");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="comeco")
        {
            EditorTexto.instance.apagatexto();
        }
    }
}
