using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour
{
    private Text score_text;
    // Start is called before the first frame update
    void Start()
    {
        score_text = GetComponent<Text>();
        gameManager.SetScore(0);
        score_text.text = gameManager.GetScore().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = gameManager.GetScore().ToString();
    }
}
