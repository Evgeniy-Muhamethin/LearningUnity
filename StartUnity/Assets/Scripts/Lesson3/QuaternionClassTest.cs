using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionClassTest : MonoBehaviour
{
    [SerializeField]
    private Transform _toTransform;
    void FixedUpdate()
    {
        if (gameObject.transform.position != _toTransform.position)
        {
            gameObject.transform.Translate(new Vector3(1 * 5 * Time.deltaTime, 0, 0));
        }
    }
}
