using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RayCastHitClass : MonoBehaviour
{
    //[SerializeField]
    //private Transform _transformStart;
    //[SerializeField]
    //private Transform _transformEnd;

    [SerializeField]
    private UnityEvent _unityEvent;

    //Интересно, надо его включить в свой проект!!!

	void Update()
    {
        RaycastHit hit;

        bool result = Physics.Raycast(gameObject.transform.position, Vector3.forward, out hit, 20);

		Debug.DrawRay(gameObject.transform.position, Vector3.forward, Color.red);

		if (result)
        {
            if (hit.collider.gameObject.CompareTag("Player") )
            {
                Debug.DrawRay(gameObject.transform.position, Vector3.forward, Color.green);
            }
        }
    }
}
