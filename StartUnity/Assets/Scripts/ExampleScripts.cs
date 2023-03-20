using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScripts : MonoBehaviour
{
    /// <summary>
    /// 
	///TODO Скриптинг, работа с объектами компонентами
    /// </summary>

		InstantiateOrDestroyObject _InstantiateOrDestroyObject;

    [SerializeField] private GameObject _gameObject;

    private int _timeDestroy;

    void Awake()
    {
        _InstantiateOrDestroyObject = new InstantiateOrDestroyObject();
    }

    void Start()
    {
        _InstantiateOrDestroyObject.InstantiateObject(_gameObject, 
            Vector3.one, new Quaternion(1,2,1,1));

        _InstantiateOrDestroyObject.DestroyObject(_gameObject, _timeDestroy);
    }

    void Update()
    {
        
    }
}
