using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float fuerzaGolpe;
    [SerializeField] GameObject testPanel;

    bool puedeMoverse = true;

    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcesarMovimiento();
    }

    void ProcesarMovimiento()
    {
        /*
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            movement.y += 1;
        if (Input.GetKey(KeyCode.D))
            movement.x += 1;
        if (Input.GetKey(KeyCode.S))
            movement.y -= 1;
        if (Input.GetKey(KeyCode.A))
            movement.x -= 1;
        */

        if (puedeMoverse == false)
            return;
        

        float inputMovementY = Input.GetAxis("Horizontal");
        float inputMovementX = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(inputMovementX * speed, rb.velocity.y);
        rb.velocity = new Vector3(inputMovementY * speed, rb.velocity.x);

        if (Input.GetKey(KeyCode.F))
        {
            testPanel.SetActive(false);
        }

    }

    public void AplicarGolpeEnemigo()
    {
        puedeMoverse = false;

        //Vector2 direccionGolpe = transform.position - contactPoint;
        Vector2 direccionGolpe;

        if (rb.velocity.x > 0)
        {
            direccionGolpe = new Vector2(-100, 0);
        }
        else if(rb.velocity.y > 0)
        {
            direccionGolpe = new Vector2(0, -100);
        }
        else if(rb.velocity.x < 0)
        {
            direccionGolpe = new Vector2(100, 0);
        }
        else if(rb.velocity.y < 0)
        {
            direccionGolpe = new Vector2(0, 100);
        }
        else
        {
            direccionGolpe = new Vector2(0, 0);
        }

        rb.AddForce(direccionGolpe * fuerzaGolpe);

        StartCoroutine(EsperarYActivarMovimiento());
    }


    IEnumerator EsperarYActivarMovimiento()
    {
        yield return new WaitForSeconds(0.3f);

        puedeMoverse = true;
    }

}
