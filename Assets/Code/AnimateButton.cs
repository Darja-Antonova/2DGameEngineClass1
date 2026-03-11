using DG.Tweening;
using UnityEngine;

public class AnimateButton : MonoBehaviour
{
    public void Click()
    {
        transform.DOPunchScale(Vector3.one * 0.2f, 0.3f);
    }
}
