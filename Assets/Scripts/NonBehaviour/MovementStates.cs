using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.Animations;

public abstract class MovementStates
{
    protected float _speed;
    protected AnimationCurve _jumpCurve;

    public MovementStates(float speed, AnimationCurve jumpCurve)
    {
        _speed = speed;
        _jumpCurve = jumpCurve;
    }

    public virtual Vector2 Move(Vector2 initialPosition, float inputDirection)
    {
        return initialPosition;
    }

    public virtual void Jump()
    {
    }
}


// different derived states
public class MovementPlayerNormal : MovementStates
{
    public MovementPlayerNormal(float speed, AnimationCurve jumpCurve) : base(speed, jumpCurve)
    {
    }

    public override void Jump()
    {

    }

    public override Vector2 Move(Vector2 initialPosition, float inputDirection)
    {
        initialPosition += Vector2.right * inputDirection * _speed * Time.deltaTime; // input direction between -1 or 1.
        return initialPosition;
    }
}
