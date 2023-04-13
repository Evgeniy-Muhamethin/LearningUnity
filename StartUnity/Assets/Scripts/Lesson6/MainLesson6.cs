using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLesson6 : MonoBehaviour
{
    private Lesson6Code _lesson6Code;

    [SerializeField]
    private Animator _animator;

    void Start()
    {
        _lesson6Code = new Lesson6Code();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
		    _lesson6Code.AnimatorWorks(_animator);
        }
	}

    private void DestroyObject()
    {
        _lesson6Code.DestroyObject(gameObject);
    }
    private void GravityFlag()
    {
        _lesson6Code.AddComponentObject(gameObject);
    }
}
