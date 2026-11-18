using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Transform playerTransform;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + playerTransform.position.z.ToString("0");
    }
}
