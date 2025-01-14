using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private float _speed;

    private MeshRenderer _meshRenderer;
    private Tween _changer;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnEnable()
    {
        _changer.Play();
    }

    private void OnDisable()
    {
        _changer.Pause();
    }

    private void OnDestroy()
    {
        _changer.Kill();
    }

    private void Start()
    {
        Change();
    }

    private void Change()
    {
        _changer = _meshRenderer.material.DOColor(Random.ColorHSV(0, 1), _speed)
            .SetEase(Ease.Linear)
            .OnComplete(() => Change());
    }
}