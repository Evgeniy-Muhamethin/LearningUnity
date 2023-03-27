using Assets.Scripts.Lesson3;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _vectorObjectOne;
	[SerializeField]
	private GameObject _vectorObjectTwo;

    [SerializeField]
    private float _speed;

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

        vectorClass.TransformPositionsObject
            (_vectorObjectOne.transform, _speed, 
            _vectorObjectTwo);
    }

	private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine
            (_vectorObjectOne.transform.position,
            _vectorObjectTwo.transform.position);
    }
}