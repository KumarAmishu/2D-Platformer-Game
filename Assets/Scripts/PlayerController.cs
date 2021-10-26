using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
  public ScoreController scoreController; 
  public float speed;

  public float jump;

  private Rigidbody2D rb2d;
  public Animator animator;
  private void Awake()
  {
    Debug.Log("Player controller awake");
    rb2d = gameObject.GetComponent<Rigidbody2D>();
  }

    public void PickUpKey()
    {
        Debug.Log("Player picked up the key");
        scoreController.IncreaseScore(10);
    }

    private void Update()

    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        bool crouch = Input.GetKeyDown(KeyCode.LeftControl);
        bool c = Input.GetKeyUp(KeyCode.LeftControl);
        Movecharacter(horizontal, vertical);
        PlayerMovementAnimation(horizontal, vertical);
        CrouchAnimation(crouch, c);
        

    }

    private void CrouchAnimation(bool crouch, bool c)
    {
        if (crouch == true)
        {

            animator.SetBool("Crouch", true);

        }

        else if (c)
        {

            animator.SetBool("Crouch", false);

        }
    }

   
     private void Movecharacter(float horizontal, float vertical)
    {

      Vector3 position = transform.position;

      position.x += horizontal * speed * Time.deltaTime;

      transform.position = position;

      if(vertical > 0){

          rb2d.AddForce(new Vector2(0f, jump), ForceMode2D.Force);

      }
    
    }

    private void PlayerMovementAnimation(float horizontal, float vertical)
    {
        animator.SetFloat("Speed", Mathf.Abs(horizontal));

        Vector3 scale = transform.localScale;

        if (horizontal < 0)
        {

            scale.x = -1f * Mathf.Abs(scale.x);

        }

        else if (horizontal > 0)
        {

            scale.x = Mathf.Abs(scale.x);

        }

         transform.localScale = scale;


          if (vertical > 0)
        {

            animator.SetBool("jump", true);

        }

        else
        {

            animator.SetBool("jump", false);

        }
    }
}

    


   

    
    












