using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xValue = 0f;
    [SerializeField] float yValue = 0f;
    [SerializeField] float zValue = 0.2f;
    void Update()
    {
        transform.Rotate(xValue, yValue, zValue);
    }
}
