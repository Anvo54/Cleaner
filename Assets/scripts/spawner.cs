using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] GameObject[] dirts;
    float min = 0;
    float max = 1.5f;
    int select;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Spawn");
    }

    void Update()
    {

    }

    // Update is called once per frame
    private IEnumerator Spawn()
    {
        select = Random.Range(0, dirts.Length);
        Instantiate(dirts[select], new Vector3(Random.Range(-2, 3), 5, 1.7f), Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(min, max));
        StartCoroutine("Spawn");
    }

}
