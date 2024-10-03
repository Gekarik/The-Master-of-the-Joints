using UnityEngine;

public class TrebuchetController : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private float _spring;
    [SerializeField] private float _damper;
    [SerializeField] private KeyCode _keyForLaunch;
    [SerializeField] private KeyCode _keyForReset;
    [SerializeField] private SpringJoint _spoon;
    [SerializeField] private Rigidbody _topPoint;
    [SerializeField] private Rigidbody _bottomPoint;
    [SerializeField] private Rigidbody _bulletPlace;

    private void Start()
    {
        _spoon.spring = _spring;
        _spoon.damper = _damper;
        _spoon.connectedBody = _bottomPoint;
        _bullet.Init(_bulletPlace);
    }

    private void Update()
    {
        if (Input.GetKeyDown(_keyForLaunch))
        {
            _spoon.connectedBody = _topPoint;
            _bullet.Launch();
        }

        if (Input.GetKeyDown(_keyForReset))
        {
            _spoon.connectedBody = _bottomPoint;
            _bullet.Reset();
        }
    }
}
