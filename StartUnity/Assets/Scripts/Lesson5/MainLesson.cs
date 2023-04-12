using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class MainLesson : MonoBehaviour
{
	[SerializeField]
	private Transform _transform;


	private float _from = 1;
	private float _to = 10;
	
	private float _time = 5.0f;

	private delegate void RandomRageMethodDelegate();

	private RandomRageMethodDelegate RandomRageDelegate;

	private void Start()
	{
		RandomRageDelegate = RandomRageMethod;
		Invoke($"RandomRageMethod", _time);
	}

	float _repeatRate = 10f;

	private void FixedUpdate()
	{
		InvokeRepeating("RandomRageMethod", _time, _repeatRate);

		if (Input.GetKey(KeyCode.Tab))
		{
			CancelInvoke();
		}
	}

	private void RandomRageMethod()
	{
		float result = Random.Range(0f, 10f);
		print(result);
	}
}
