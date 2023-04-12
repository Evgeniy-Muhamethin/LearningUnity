using UnityEngine;

public class TestCode
{
    public void MoveObject(Transform objectTransform)
    {
        objectTransform.Translate(Vector3.forward * Time.deltaTime);
    }

    public void RayCastHit()
    {

    }
}
