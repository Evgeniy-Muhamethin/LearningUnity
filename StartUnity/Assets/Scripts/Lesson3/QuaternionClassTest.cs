using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionClassTest : MonoBehaviour
{
    [SerializeField]
    private Transform _from;

    void FixedUpdate()
    {
        //transform.rotation = Quaternion.Slerp(_from.rotation, _to.rotation, Time.time);
        //print($"{transform.rotation}");

        //gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.forward, Vector3.up);

        transform.RotateAround(_from.position, Vector3.forward, 10);
    }
}
