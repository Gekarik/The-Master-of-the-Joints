using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    private FixedJoint _joint;
    private Rigidbody _connectedBody;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        TryGetComponent(out _joint);
    }

    public void Init(Rigidbody _bulletPlace)
    {
        _connectedBody = _bulletPlace;
    }

    public void Launch()
    {
        Destroy(_joint);
    }

    public void Reset()
    {
        if (_joint == null)
        {
            _rigidbody.velocity = Vector3.zero;
            transform.position = _connectedBody.transform.position;
            _joint = this.AddComponent<FixedJoint>();
            _joint.connectedBody = _connectedBody;
        }
    }
}
