using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextWriter : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _speed;
    [SerializeField] private char _symbol;
    [SerializeField] private string _firstMessage;
    [SerializeField] private string _secondMessage;
    [SerializeField] private string _thirdMessage;

    private Sequence _writer;

    private void Awake()
    {
        _writer = DOTween.Sequence();
    }

    private void OnDestroy()
    {
        _writer.Kill();
    }

    private void Start()
    {
        Write();
    }

    private void Write()
    {
        _writer.Append(_text.DOText(_firstMessage, _speed))
        .Append(_text.DOText(_secondMessage, _speed, false, ScrambleMode.Custom, _symbol.ToString()))
        .Append(_text.DOText(_thirdMessage, _speed, false, ScrambleMode.All));
    }
}