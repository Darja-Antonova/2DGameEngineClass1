using UnityEngine;
using DG.Tweening;

public class JumpExample : MonoBehaviour
{
    void Start()
    {
        transform.DOJump(new Vector3(-4.21999979f, 2.31999993f, 0), 0.5f, 3, 3f);
    }

    void Update()
    {
        
    }
}
