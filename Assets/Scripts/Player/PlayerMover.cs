using UniRx;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private PlayerCore _core;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speed;

    void Start()
    {
        _core.MoveAsObservable()
            .ObserveOn(Scheduler.MainThreadFixedUpdate)
            .Subscribe(Move)
            .AddTo(this);
    }

    void Move(Vector2 delta)
    {
        _rb.MovePosition(_rb.position + (delta * _speed * Time.deltaTime).X0Y());
    }
}
