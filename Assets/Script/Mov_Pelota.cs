using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Pelota : MonoBehaviour
{

    public float velocidad = 10f;
    public Rigidbody2D pelota;

    // Start is called before the first frame update
    void Start()
    {
        pelota = GetComponent<Rigidbody2D>();
        salida_pelota();
    }

    private void salida_pelota(){
        if (Random.Range(0,3)==0)
        {
            pelota.velocity= new Vector2(1*velocidad,1*velocidad);
        }
        else if (Random.Range(0,3)==1)
        {
            pelota.velocity= new Vector2(-1*velocidad,1*velocidad);
        }
        else if (Random.Range(0,3)==2)
        {
            pelota.velocity= new Vector2(1*velocidad,-1*velocidad);
        }
        else if (Random.Range(0,3)==3)
        {
            pelota.velocity= new Vector2(-1*velocidad,-1*velocidad);
        }
    }


    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.name == "Paleta")
        {
            pelota.velocity *= 1.1f;
        }
    }

}
