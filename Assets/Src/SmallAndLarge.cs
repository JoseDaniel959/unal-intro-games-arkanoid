using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallAndLarge : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.collider.CompareTag("base") )
        {
            
            if(this.transform.CompareTag("Large")){
                
                
                Vector3 lTemp = GameObject.Find("Paddle").transform.localScale;
                lTemp.x += 0.2f;
                GameObject.Find("Paddle").transform.localScale = lTemp;
                Destroy((this.gameObject));
            }
            else if(this.transform.CompareTag("Small")){
                
                Vector3 lTemp = GameObject.Find("Paddle").transform.localScale;
                lTemp.x -= 0.2f;
                GameObject.Find("Paddle").transform.localScale = lTemp;
                Destroy((this.gameObject));
            }
            

            //Debug.Log(ArkanoidController._totalScore);
            Debug.Log("colision detectada");
            //Debug.Log(ArkanoidController._totalScore+50);
            
        }
    
        
        if(other.collider.CompareTag("Bottom")){
            Destroy((this.gameObject));
        }
    
    }
    
       
}
