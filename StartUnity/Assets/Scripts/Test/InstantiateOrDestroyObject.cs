using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateOrDestroyObject
{
    public void InstantiateObject(GameObject gameObjectInstantiate, 
        Vector3 transform, Quaternion quaternion)
    {
        MonoBehaviour.Instantiate(gameObjectInstantiate, transform, quaternion);
    }

    public void DestroyObject(GameObject gameObject, int timeDestroy)
    {
        MonoBehaviour.Destroy(gameObject, timeDestroy);
    }
}
