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
            .Append(_text.DOText("Новый анимационный текст", _delay))
            .Append(_text.DOText(" Дополнение к тексту", _delay).SetRelative())
            .Append(_text.DOText("Перебрали текст на новый", _delay, true, ScrambleMode.All));
    }
}
