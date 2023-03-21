using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    public void SetActiveObject(GameObject gameObject, bool flag)
    {
        gameObject.SetActive(flag);
    }

    //отключение родительского объекта совсей его ирархией
	public void SetActiveObject(Transform transform,bool flag)
	{
		transform.parent.gameObject.SetActive(flag);
	}

	public void SetActiveObject(Transform transform, bool flag, int numberChild)
	{
		transform.GetChild(numberChild).gameObject.SetActive(flag);
	}

    public bool FindGameObjectTags(string tags)
    {
        bool result = false;
        GameObject.FindGameObjectWithTag(tags);
        Debug.Log($"{tags.ToString()} is find");
        return result = true;
    }

	public int LayersTesting(GameObject gameObject)
	{
        int result = gameObject.layer;
        return result;
	}
}
