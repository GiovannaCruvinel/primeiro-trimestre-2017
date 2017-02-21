using UnityEngine;

public class PranchaMove : MonoBehaviour {

    public float velocidade;

	void Start () {
		
	}
	

	void Update () {
        Vector3 velocidadeVectorial = Vector3.left * velocidade;

        transform.position = transform.position + velocidadeVectorial * Time.deltaTime;
	}
}
