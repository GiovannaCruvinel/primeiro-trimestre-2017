using UnityEngine;

public class PranchaMove : MonoBehaviour {

    public float velocidade;
    public float limite;
    public float retorno;

    public AudioClip somMorte;
    private AudioSource audioSource;
    private Animator anim;
    private Rigidbody rb;

    void Start () {
		
	}
	

	void Update () {
        Vector3 velocidadeVectorial = Vector3.left * velocidade;

        transform.localPosition = transform.localPosition + velocidadeVectorial * Time.deltaTime;

        if (transform.localPosition.x <= limite) {
            transform.localPosition = new Vector3(retorno, transform.localPosition.y, transform.localPosition.z);
        }
	}

    void OnCollisionEnter(Collision outro)
    {
        if (GameController.instancia.estado == Estado.Jogando)
        {
            if (outro.gameObject.tag == "obstaculo")
            {
                rb.velocity = Vector3.zero;
                rb.AddForce(new Vector3(-50f, 20f, 0f), ForceMode.Impulse);
                rb.detectCollisions = false;
                anim.Play("morrendo");
                audioSource.PlayOneShot(somMorte);
                GameController.instancia.PlayerMorreu();
            }
        }
    }
}
