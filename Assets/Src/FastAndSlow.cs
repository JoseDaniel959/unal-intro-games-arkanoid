using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastAndSlow : MonoBehaviour
{
    public float velocidad = 7;
    private Rigidbody2D _rb;
    private Collider2D _collider;
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.collider.CompareTag("base") )
        {
            
            if(this.transform.CompareTag("Fast")){
                _rb =  GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody2D>();
                 _rb.velocity = new Vector2(7, 7);
                //GameObject.FindGameObjectWithTag("Ball").GetComponent<RigidBody>().AddForce(transform.fordward+velocidad);
                Debug.Log("Se aumenta la velocidad");
                Destroy((this.gameObject));
            }
            else if(this.transform.CompareTag("Slow")){
                _rb =  GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody2D>();
                 _rb.velocity = new Vector2(1, 1);
                //GameObject.FindGameObjectWithTag("Ball").GetComponent<RigidBody>().AddForce(transform.fordward+velocidad);
                Debug.Log("Se Disminuye");
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
