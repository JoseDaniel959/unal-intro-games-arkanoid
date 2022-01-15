using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.collider.CompareTag("base") )
        {
            
            if(this.transform.CompareTag("50 puntos")){
                Debug.Log("se suman 50 puntos");
                ArkanoidController._totalScore += 50; 
                Debug.Log("Puntaje actual " + ArkanoidController ._totalScore);
                Destroy((this.gameObject));
            }
            if(this.transform.CompareTag("100 puntos")){
                Debug.Log("se suman 100 puntos");
                ArkanoidController._totalScore += 100; 
                Debug.Log("Puntaje actual " + ArkanoidController ._totalScore);
                Destroy((this.gameObject));
            }
            if(this.transform.CompareTag("250 puntos")){
                Debug.Log("se suman 250 puntos");
                ArkanoidController._totalScore += 250; 
                Debug.Log("Puntaje actual " + ArkanoidController ._totalScore);
                Destroy((this.gameObject));
            }
            if(this.transform.CompareTag("500 puntos")){
                Debug.Log("se suman 500 puntos");
                ArkanoidController._totalScore += 500; 
                Debug.Log("Puntaje actual " + ArkanoidController ._totalScore);
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
