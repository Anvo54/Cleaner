using UnityEngine.UI;
using UnityEngine;

public class LeftScore : MonoBehaviour
{
    // Start is called before the first frame update
 [SerializeField] private Text leftScoreText;
    // Start is called before the first frame update
    void Start()
    {
        leftScoreText = GetComponent<Text>();
        gameManager.SetLeftScore(0);
        leftScoreText.text = gameManager.GetLeftScore().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        leftScoreText.text = gameManager.GetLeftScore().ToString();
    }
}
