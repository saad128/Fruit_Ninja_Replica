using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{

    [SerializeField] private GameObject fruitsPrefabs;
    [SerializeField] private float spawnInterval, objectMinX, objectMaxX, objectY;
    [SerializeField] private List<Sprite> objectSprites;


    private void Start()
    {
        InvokeRepeating("SpawnObject", this.spawnInterval, this.spawnInterval);
    }
    void SpawnObject()
    {
        GameObject newObject = Instantiate(this.fruitsPrefabs);
        newObject.transform.position = new Vector2(Random.Range(this.objectMinX, this.objectMaxX), this.objectY);

        Sprite objectSprite = objectSprites[Random.Range(0, this.objectSprites.Count)];
        newObject.GetComponent<SpriteRenderer>().sprite = objectSprite;

    }

}
