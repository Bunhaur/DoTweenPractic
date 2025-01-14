using DG.Tweening;
using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Tween _sizer;

    private void OnEnable()
    {
        _sizer.Play();
    }

    private void OnDisable()
    {
        _sizer.Pause();
    }

    private void OnDestroy()
    {
        _sizer.Kill();
    }

    private void Start()
    {
        Resize();
    }

    private void Resize()
    {
        _sizer = transform.DOScale(transform.localScale + Vector3.one, _speed)
            .SetEase(Ease.Linear)
            .OnComplete(() => Resize());
    }
}