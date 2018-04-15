using System;
using UnityEngine;

interface IInputEventProvider
{
    IObservable<Vector2> MoveAsObservable();
}
