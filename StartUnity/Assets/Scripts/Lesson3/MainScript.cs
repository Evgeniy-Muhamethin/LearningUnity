using Assets.Scripts.Lesson3;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _vectorObjectOne;
	[SerializeField]
	private GameObject _vectorObjectTwo;

	private VectorClass vectorClass;

    void Start()
    {
        vectorClass = new VectorClass();
    }

    void Update()
    {
        float result = vectorClass.DistanceObject
            (_vectorObjectOne.transform.position,
            _vectorObjectTwo.transform.position);
        print($"{result}");

        vectorClass.ScalarAndVectorMultiple
            (_vectorObjectOne.transform.position,
			_vectorObjectTwo.transform.position);
    }

	private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine
            (_vectorObjectOne.transform.position,
            _vectorObjectTwo.transform.position);
    }
}
