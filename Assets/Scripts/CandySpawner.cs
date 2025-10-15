using UnityEngine;
using System.Collections;

public class CandySpawner : MonoBehaviour
{
    public GameObject candyPrefab;
    [SerializeField] public float time;
    [SerializeField] public float minY;
    [SerializeField] public float maxY;

    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            Vector3 position = new Vector3(transform.position.x, Random.Range(minY, maxY), 0);
            Instantiate(candyPrefab, position, Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}
