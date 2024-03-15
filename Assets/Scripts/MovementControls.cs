using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControls : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private AnimationCurve _jumpCurve;
    private Transform _selfTransform;
    private MovementStates _state;

    private void Start()
    {
        _selfTransform = transform;
        _state = new MovementPlayerNormal(_speed, _jumpCurve);
    }

    private void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        Vector2 resultMovement = _state.Move(_selfTransform.position, direction);
        _selfTransform.position = resultMovement;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _state.Jump();
        }
    }
}
