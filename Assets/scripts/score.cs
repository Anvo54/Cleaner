using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour
{
    [SerializeField] private Text rightScoreText;
    // Start is called before the first frame update
    void Start()
    {
        rightScoreText = GetComponent<Text>();
        gameManager.SetRightScore(0);
        rightScoreText.text = gameManager.GetRightScore().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        rightScoreText.text = gameManager.GetRightScore().ToString();
    }
}
