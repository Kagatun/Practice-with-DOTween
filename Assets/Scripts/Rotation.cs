using UnityEngine;
using DG.Tweening;

public class Rotation : MonoBehaviour
{
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeat;

    private void Start()
    {
        transform.DORotate(_rotation, _duration, RotateMode.FastBeyond360)
            .SetLoops(_repeat, _loopType).SetEase(Ease.Linear);
    }
}
