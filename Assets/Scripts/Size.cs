using UnityEngine;
using DG.Tweening;

public class Size : MonoBehaviour
{
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Vector3 _size;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeat;

    private void Start()
    {
        transform.DOScale(_size, _duration).SetLoops(_repeat, _loopType).SetEase(Ease.Linear);
    }
}
