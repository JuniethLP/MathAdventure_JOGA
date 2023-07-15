using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{

    private float movimientoHorizontal = 0f;

    private float movimientoVertical = 0f;

    public Joystick Joystick;

    public float runSpeedHorizontal = 2;

    // Variable que le otorga la velocidad al correr o moverse.
    public float runSpeed = 2f;

    // VAriable que le otorga la distancia del salto al personaje.
    public float jumpSpeed = 3;

    public float fuerzaSalto;

    public bool estaSaltando;


    // Declaración de variable tipo Rigidbody2D para obtener propiedades del objeto personaje.
    Rigidbody2D rg2D;

    public SpriteRenderer spriteRenderer;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rg2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        this.avanzarRetroceder();
    }

    private void FixedUpdate()
    {
        movimientoHorizontal = Joystick.Horizontal * runSpeedHorizontal;
        transform.position += new Vector3(movimientoHorizontal, 0, 0) * Time.deltaTime * runSpeed;
    }

    private void avanzarRetroceder()
    {
        if (movimientoHorizontal > 0)
        {
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);

        }
        else if (movimientoHorizontal < 0)
        {
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }

        if (VerificaSalto.estaEnPiso == false)
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
        if (VerificaSalto.estaEnPiso == true)
        {

            animator.SetBool("Jump", false);
        }
    }

    public void Salto() 
    {

        if (VerificaSalto.estaEnPiso)
        {
            rg2D.velocity = new Vector2(rg2D.velocity.x, jumpSpeed);
            animator.SetBool("Run", false);
        }

        if (VerificaSalto.estaEnPiso == false)
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
        if (VerificaSalto.estaEnPiso == true)
        {
            animator.SetBool("Jump", false);
        }

    }
}
