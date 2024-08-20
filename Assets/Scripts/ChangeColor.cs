using UnityEngine;
using DG.Tweening;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;

    private float _duration = 3f;

    private void Start()
    {
        ChangeToRandomColor();
    }

    private void ChangeToRandomColor()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value);

        _renderer.material.DOColor(randomColor, _duration)
            .SetEase(Ease.Linear)
            .SetLoops(1, LoopType.Restart)
            .OnStepComplete(ChangeToRandomColor);
    }
}
