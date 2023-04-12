using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using UnityEngine;
using UnityEngine.Playables;

public class MainLesson : MonoBehaviour
{
	[SerializeField]
	private Transform _transform;

	TestCode _testCode;

	private void Start()
	{
		_testCode = new TestCode();
	}

	private void FixedUpdate()
	{
		StartCoroutine(TransformObject(_transform));
		if (Input.GetKey(KeyCode.Space))
		{
			StopCoroutine(TransformObject(_transform));
		}
	}

	WaitForSeconds _waitTime = 
		new WaitForSeconds(0.1f);

	IEnumerator TransformObject(Transform transform)
	{
		_testCode.MoveObject(transform);
		print("Corutine");
		yield return _waitTime;
	}

	private void RandomRageMethod()
	{
		float result = UnityEngine.Random.Range(0f, 10f);
		print(result);
	}
}
