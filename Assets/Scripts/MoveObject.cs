using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] private float maxSpeedX, minSpeedX, maxSpeedY, minSpeedY;
    [SerializeField] private float destroyTime;

    private void Start()
    {
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minSpeedX, maxSpeedX), Random.Range(minSpeedY, maxSpeedY));
        Destroy(this.gameObject, this.destroyTime);
    }
}
