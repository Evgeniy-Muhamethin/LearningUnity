﻿using UnityEngine;

namespace Assets.Scripts.Lesson3
{
	internal class VectorClass
	{
		public void LenthVectorObject(Vector3 vector3)
		{
			Debug.Log($"{vector3.magnitude}");
		}

		public float DistanceObject(Vector3 objecOne, Vector3 objectTwo)
		{
			float result;
			result = Mathf.Sqrt((objecOne - objectTwo).sqrMagnitude);	
			return result;
		}

		public void ScalarAndVectorMultiple(Vector3 p1, Vector3 p2)
		{
			//Скалярное произведение
			Debug.Log($"Scalar {Vector3.Dot(p1, p2)}");
			//Векторное произведение 
			Debug.Log($"Vector {Vector3.Cross(p1, p2)}");
		}

		//движение объекта 
		public void TransformPositionsObject(Transform transformObject, float speed)
		{
			transformObject.transform.position =
				transformObject.transform.position + Vector3.forward * 
				speed * Time.deltaTime;
		}
		//движение объекта по отношению к другому объекту 
		public void TransformPositionsObject(Transform transformObject, float speed,
			GameObject gameObjectTo)
		{
			transformObject.Translate(Vector3.back * speed * Time.deltaTime,
				gameObjectTo.transform);
		}
	}
}