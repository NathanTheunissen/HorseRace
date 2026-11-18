using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] private GameManager gameManagerScript;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Debug.Log("Tu as atteins la ligne d'arrivée");
            gameManagerScript.CompleteLevel();
        }
    }
}
