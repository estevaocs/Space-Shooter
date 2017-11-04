using System.Collections;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    public GameObject explosion;
    public GameObject playerExplosion;
    public int scoreValue;

    private GameController gameController;

    private void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log ("Não foi encontrado o script 'GameController'");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag != "Boundary")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            if(other.tag == "Player")
            {
                Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
                gameController.GameOver();
            }
            Destroy(other.gameObject);
            Destroy(gameObject);
            gameController.GetComponent<GameController>().AddScore(scoreValue);
        }
        
    }
}
