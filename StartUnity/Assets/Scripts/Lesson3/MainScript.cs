using Assets.Scripts.Lesson3;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    [SerializeField]
    private Transform _vectorObjectOne;
	[SerializeField]
	private Transform _vectorObjectTwo;
    [SerializeField]
    private Transform _upAwards;

    [SerializeField]
    private float _speed;

	private VectorClass vectorClass;

    void Start()
    {
        vectorClass = new VectorClass();
    }

    void Update()
    {
        transform.rotation =
            Quaternion.Slerp(
                _vectorObjectTwo.rotation,
                _upAwards.rotation, Time.deltaTime * _speed);
        _vectorObjectOne.rotation = transform.rotation;
    }

    //private void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.blue;
    //    Gizmos.DrawLine
    //        (_vectorObjectOne.transform.position,
    //        _vectorObjectTwo.transform.position);
    //}
}