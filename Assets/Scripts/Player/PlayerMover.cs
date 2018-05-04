using System.Linq;
using UniRx;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private PlayerCore _core;
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private float _speed;

    void Start()
    {
        _core.MoveAsObservable()
            .Subscribe(Move)
            .AddTo(this);
    }

    void Move(Vector2 delta)
    {
        //_agent.MovePosition(_agent.position + (delta * _speed).X0Y());
        _agent.velocity = (delta * _speed).X0Y();
    }
}
