using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BossMovement : MonoBehaviour
{
    public float speed = 2.0f;
    public float distance = 5.0f;
    public float waitTime = 5.0f;

    private Vector3 startPosition;
    private bool movingRight = true;
    private float timer;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector3.right * speed * Time.deltaTime);
        }

        if (transform.position.x >= startPosition.x + distance)
        {
            movingRight = false;
        }
        else if (transform.position.x <= startPosition.x - distance)
        {
            movingRight = true;
        }

        if (!movingRight)
        {
            timer += Time.deltaTime;

            if (timer >= waitTime)
            {
                MoveBackToStartPosition();
            }
        }
    }

    private void MoveBackToStartPosition()
    {
        Vector3 targetPosition = startPosition;
        Vector3 currentPosition = transform.position;

        float step = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(currentPosition, targetPosition, step);

        if (currentPosition == targetPosition)
        {
            movingRight = true;
            timer = 0f;
        }
    }





}
