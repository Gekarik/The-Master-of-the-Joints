using UnityEngine;

public class ForceAdder : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private KeyCode _swingKey = KeyCode.Space;
    [SerializeField] private Rigidbody _swing;

    private void Update()
    {
        if (Input.GetKeyUp(_swingKey))
            _swing.AddForce(_force * Vector3.forward);
    }
}
