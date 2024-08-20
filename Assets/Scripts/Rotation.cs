using UnityEngine;
using DG.Tweening;

public class Rotation : MonoBehaviour
{
    [SerializeField] private LoopType _loopType;
    [SerializeField] private float _rotationX;
    [SerializeField] private float _rotationY;
    [SerializeField] private float _rotationZ;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeat;

    private void Start()
    {
        transform.DORotate(new Vector3(_rotationX, _rotationY, _rotationZ), _duration, RotateMode.FastBeyond360)
            .SetLoops(_repeat, _loopType).SetEase(Ease.Linear);
    }
}
