using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutBomb : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cut"))
        {
            Destroy(this.gameObject);
        }
    }
}
