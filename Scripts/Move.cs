using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float moveSpeed = 8;
    public float changeSpeed = 4;
    void Update()

    {

        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);


        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)

            {
                transform.Translate(Vector3.left * Time.deltaTime * changeSpeed);
            }
        }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < LevelBoundary.rightSide)

                {
                    transform.Translate(Vector3.left * Time.deltaTime * changeSpeed * -1);
                }
            }
        } }
