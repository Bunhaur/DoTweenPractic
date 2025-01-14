using UnityEngine;
using DG.Tweening;

public class Rotater : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _target;

    private Tween _rotater;

    private void OnEnable()
    {
        _rotater.Play();
    }

    private void OnDisable()
    {
        _rotater.Pause();
    }

    private void OnDestroy()
    {
        _rotater.Kill();
    }

    private void Start()
    {
        Rotate();
    }

    private void Rotate()
    {
        _rotater = transform.DORotate(_target, _speed, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1);
    }
}
