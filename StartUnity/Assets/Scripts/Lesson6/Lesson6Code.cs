using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6Code 
{
    public void DestroyObject(GameObject gameObject)
    {
        MonoBehaviour.Destroy(gameObject);
    }

    public void AddComponentObject(GameObject gameObject)
    {
        gameObject.AddComponent<Rigidbody>();

        if (gameObject.GetComponent<Rigidbody>() == null)
        {
            Debug.LogError("Rigid body component is not found");
        }
        else if (gameObject.GetComponent<Rigidbody>() != null)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true; 
        }
	}

    public void AnimatorWorks(Animator animator)
    {
        animator.SetBool("Translater", !animator.GetBool("Translater"));
    }
}
