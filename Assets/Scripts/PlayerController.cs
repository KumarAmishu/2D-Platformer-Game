using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
  public Animator animator;
  private void Awake()
  {
    Debug.Log("Player controller awake");
  }
 
  private void Update()
  
  {

   float speed = Input.GetAxisRaw("Horizontal");
   
   animator.SetFloat("Speed", Mathf.Abs(speed));
   
   Vector3 scale = transform.localScale;
   
   if(speed<0){
    
    scale.x = -1f * Mathf.Abs(scale.x);
   
   }

   else if(speed>0){
    
    scale.x = Mathf.Abs(scale.x);
   
   } 
   
  float jump = Input.GetAxisRaw("Vertical");


   if(jump > 0){

    
  animator.SetBool("jump", true) ;
   
   }
   
   else {
    
      animator.SetBool("jump", false) ;

   
    } 
   

   bool crouch = Input.GetKeyDown(KeyCode.LeftControl);
   
   bool c = Input.GetKeyUp(KeyCode.LeftControl);

   if(crouch == true){

    animator.SetBool("Crouch", true);
   
   }
   
   else if(c){
    
    animator.SetBool("Crouch", false);
     
   }

   transform.localScale = scale;

   }
    
  
  }


  

 
   

