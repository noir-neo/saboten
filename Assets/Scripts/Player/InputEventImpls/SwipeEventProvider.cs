using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SwipeEventProvider : MonoBehaviour, IInputEventProvider
{
    [SerializeField] private Button button;

    private IObservable<PointerEventData> OnDragAsObservable()
    {
        return button.OnDragAsObservable();
    }

    IObservable<Vector2> IInputEventProvider.MoveAsObservable()
    {
        return OnDragAsObservable()
            .TakeUntilDestroy(this)
            .Select(x => x.delta);
    }
}
