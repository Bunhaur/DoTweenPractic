using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Tween _mover;

    private void OnEnable()
    {
        Start();
    }

    private void OnDisable()
    {
        _mover.Pause();
    }

    private void OnDestroy()
    {
        _mover.Kill();
    }

    private void Start()
    {
        Move();
    }

    private void Move()
    {
        _mover = transform.DOMove(transform.position + Vector3.back, _speed)
            .SetEase(Ease.Linear)
            .OnComplete(() => Move());
    }
}