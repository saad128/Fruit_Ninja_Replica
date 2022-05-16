using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCuts : MonoBehaviour
{
    [SerializeField] private GameObject cut;
    [SerializeField] private float cutTime;
    [SerializeField] private bool isDragging = false;
    private Vector2 swipeStart;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            this.isDragging = true;
            this.swipeStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }else if (Input.GetMouseButtonUp(0) && this.isDragging)
        {
            this.createCut();
        }
    }

    void createCut()
    {
        isDragging = false;
        Vector2 swipeEnd = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GameObject cut = Instantiate(this.cut, this.swipeStart, Quaternion.identity) as GameObject;
        cut.GetComponent<LineRenderer>().SetPosition(0, swipeStart);
        cut.GetComponent<LineRenderer>().SetPosition(1, swipeEnd);

        Vector2[] colliderPoints = new Vector2[2];
        colliderPoints[0] = new Vector2(0.0f, 0.0f);
        colliderPoints[1] = swipeEnd - this.swipeStart;

        cut.GetComponent<EdgeCollider2D>().points = colliderPoints;
        Destroy(cut.gameObject, this.cutTime);
    }
}
