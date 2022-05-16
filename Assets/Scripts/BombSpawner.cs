using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnBomb;
    [SerializeField] private float spawnInterval, objectMinX, objectMaxX, objectY;
    [SerializeField] private Sprite[] bombSprites;

    void Start()
    {
        InvokeRepeating("SpawnObject", this.spawnInterval, this.spawnInterval);
    }

    void SpawnObject()
    {
        GameObject newObject = Instantiate(spawnBomb);
        newObject.transform.position = new Vector2(Random.Range(objectMinX, objectMaxX), objectY);

        Sprite bombSprite = bombSprites[Random.Range(0, this.bombSprites.Length)];
        newObject.GetComponent<SpriteRenderer>().sprite = bombSprite;

    }
}
