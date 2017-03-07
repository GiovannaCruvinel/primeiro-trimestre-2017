using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morcego : MonoBehaviour {
	
	public float velocidade;
	public float min;
    public float max;
    public float espera;
	
	
	public float velocidade2 = 1f;
	 

	void Start () {
		
	StartCoroutine(Move(max));
    }

    IEnumerator Move(float destino)
    {
        while (Mathf.Abs(destino - transform.localPosition.y) > 0.2f)
        {
            Vector3 direcao = (destino == max) ? Vector3.up : Vector3.down;
            Vector3 velocidadeVetorial = direcao * velocidade;
            transform.localPosition = transform.localPosition + velocidadeVetorial * Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSeconds(espera);

        destino = (destino == max) ? min : max;
        StartCoroutine(Move(destino));
	}
		
		void Update () {
        Vector3 velocidadeVectorial1 = Vector3.left * velocidade2;

        transform.localPosition = transform.localPosition + velocidadeVectorial1 * Time.deltaTime;

         
	}
		}
