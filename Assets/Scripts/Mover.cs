using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeat;

    private void Start()
    {
        transform.DOMove(_position, _duration).SetLoops(_repeat, _loopType).SetEase(Ease.Linear);
    }
}
