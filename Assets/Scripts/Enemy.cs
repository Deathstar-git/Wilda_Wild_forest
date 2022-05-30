using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   public int health;
   private Animator anim;

   void Start()
   {
       anim = GetComponent<Animator>();
   }
   void Update (){
       if(health <= 0) {
           Destroy(gameObject);
       }
   }
   public void TakeDamage(int damage) {
       anim.Play("damage2");
       health -= damage;
   }
}
