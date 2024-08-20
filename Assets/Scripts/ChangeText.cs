using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text;

    private float _delay = 3f;

    private void Start()
    {
        DOTween.Sequence()
            .Append(_text.DOText("����� ������������ �����", _delay))
            .Append(_text.DOText(" ���������� � ������", _delay).SetRelative())
            .Append(_text.DOText("��������� ����� �� �����", _delay, true, ScrambleMode.All));
    }
}
