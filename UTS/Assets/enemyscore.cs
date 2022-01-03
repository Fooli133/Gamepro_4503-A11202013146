using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class enemyscore : MonoBehaviour
{
    // Start is called before the first frame update
    
   private int Enemy = 0;
   [SerializeField] private Text EnemyText;
   private void onTriggerEnter2D(Collider2D collision)
   {
       if (collision.gameObject.CompareTag("Enemy"))
       {
           Destroy(collision.gameObject);
           enemy++;
           EnemyText.text = "Enemy :" + Enemy;
       }
   }
}