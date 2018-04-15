using System;
using UnityEngine;
using Zenject;

public class PlayerCore : MonoBehaviour
{
    private IInputEventProvider _inputEventProvider;

    [Inject]
    void Initialize(IInputEventProvider inputEventProvider)
    {
        _inputEventProvider = inputEventProvider;
    }

    public IObservable<Vector2> MoveAsObservable()
    {
        return _inputEventProvider.MoveAsObservable();
    }
}
