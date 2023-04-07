using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionClassTest : MonoBehaviour
{
    [SerializeField]
    private Transform _toTransform;

    private float _speed = 3;

    void FixedUpdate()
    {
        if (gameObject.transform.position != _toTransform.position)
        {
            gameObject.transform.position += Vector3.MoveTowards(gameObject.transform.position,
                _toTransform.position, _speed * Time.deltaTime);

		}
    }
}
