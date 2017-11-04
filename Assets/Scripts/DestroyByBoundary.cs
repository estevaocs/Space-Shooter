using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour
{
    public int punishmentScoreValue;

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
            Debug.Log("Não foi encontrado o script 'GameController'");
        }
    }

    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
        if (other.tag == "Asteroid")
        {
            gameController.GetComponent<GameController>().AddScore(punishmentScoreValue);
        }
    }
}