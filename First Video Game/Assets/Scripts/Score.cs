using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public Transform player;
    void Update ()
    {
        scoreText.text = player.position.z.ToString("0"); 
    }
}
