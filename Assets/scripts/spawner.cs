using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] GameObject[] dirts;
    float min = 0;
    float max = 0.5f;
    int select;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Spawn");
    }

    void Update()
    {
        select = Random.Range(0, dirts.Length);
        if ((gameManager.GetLeftScore() + gameManager.GetRightScore()) % 10 == 2){
            if (max > 1)
                max--;
            else max = 3;
        }
    }

    // Update is called once per frame
    private IEnumerator Spawn()
    {
        Instantiate(dirts[select], new Vector3(Random.Range(-2f, 3f), 5, 1.7f), Quaternion.identity);
        Instantiate(dirts[select], new Vector3(Random.Range(-2f, 3f), 5, 1.7f), Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(min, max));
        StartCoroutine("Spawn");
    }
}
