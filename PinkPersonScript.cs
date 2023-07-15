using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltoScripts : MonoBehaviour
{
    // Variable que le otorga la velocidad al correr o moverse.
    public float runSpeed = 2;

    // VAriable que le otorga la distancia del salto al personaje.
    public float jumpSpeed = 6;

    public float fuerzaSalto;

    public bool estaSaltando;

    // Declaración de variable tipo Rigidbody2D para obtener propiedades del objeto personaje.
    Rigidbody2D rg2D;

    public bool betterJump = false;

    public float fallMultiplier = 0.5f;

    public float lowJumpMultiplier = 1.0f;

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

    private void avanzarRetroceder()
    {
         if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rg2D.velocity = new Vector2(runSpeed, rg2D.velocity.y);
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);

        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rg2D.velocity = new Vector2(-runSpeed, rg2D.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        }
        else
        {
            rg2D.velocity = new Vector2(0, rg2D.velocity.y);
            animator.SetBool("Run", false);
        }   

        if (Input.GetKey("space") && VerificaSalto.estaEnPiso) {
            rg2D.velocity = new Vector2(rg2D.velocity.x, jumpSpeed);
            animator.SetBool("Run", false);
        }

        if (VerificaSalto.estaEnPiso == false) {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
        if (VerificaSalto.estaEnPiso == true) {

            animator.SetBool("Jump", false);
        }

        if (betterJump) {
            if (rg2D.velocity.y < 0) {
                rg2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier) * Time.deltaTime;
            }

            if (rg2D.velocity.y > 0 && !Input.GetKey("space"))
            {
                rg2D.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier) * Time.deltaTime;
            }
        }
    }
}
