using System;
using System.Linq;
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
        return this.UpdateAsObservable().Select(_ => Vector2.zero)
            .Merge(OnDragAsObservable().Select(x => x.delta))
            .BatchFrame()
            .Select(x => x.Sum());
    }
}
