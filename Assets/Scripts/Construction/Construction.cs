using UnityEngine;

public class Construction : MonoBehaviour
{
    [SerializeField] protected GameObject target;
    [SerializeField] private float valueForce, valueImpulse;
    private Vector3 _direction;
    private Rigidbody _rigidbody;
    private bool _crash;
    private float _timeLeft;
    public int CountPoke { get; set; }

    private void Awake()
    {
        _rigidbody = this.GetComponent<Rigidbody>();
        _timeLeft = 0.5f;
    }

    internal void AttractionTarget()
    {
        _direction = (target.transform.position - transform.position).normalized;
        if (_crash == false)
            _rigidbody.AddForce(_direction * valueForce, ForceMode.Acceleration);
        else
            CanMove();
    }

    private void CanMove()
    {
        _timeLeft -= Time.deltaTime;

        if (_timeLeft <= 0)
        {
            _crash = false;
            _timeLeft = 0.5f;
            CountPoke++;
        }
    }

    private void OnCollisionEnter()
    {
        _crash = true;
        _rigidbody.AddForce(-_direction * valueImpulse, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Target") && _crash == false)
        {
            this._rigidbody.velocity = Vector3.zero;
        }
    }
}