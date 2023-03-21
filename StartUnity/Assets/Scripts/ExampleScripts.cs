using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScripts : MonoBehaviour
{
    InstantiateOrDestroyObject _InstantiateOrDestroyObject;

    [SerializeField] private Vector3 _gameObject;
    [SerializeField] private float _speedPlayer;

    void Start()
    {
		_InstantiateOrDestroyObject = new
			InstantiateOrDestroyObject();
	}

    void Update()
    {
		//Движение персонажа на основе Axis
		_gameObject.x = Input.GetAxis("Horizontal");
		_gameObject.y = Input.GetAxis("Vertical");

		var speed = _gameObject * _speedPlayer * Time.deltaTime;
        transform.Translate(speed);
	}
}
