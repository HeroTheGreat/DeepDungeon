using DG.Tweening;
using UnityEngine;
public class Movement : MonoBehaviour
{
    public float distance = 30;
    public float duration = 1;
    private Vector3 rayDirection;
    private void Update()
    {
        CheckEnemy();
    }

    public void OnSwipeNorth()
    {
        rayDirection = Vector3.forward;
        if(hit.collider != null)
        transform.DOMoveZ(distance, duration).SetEase(Ease.Linear).OnComplete(OnComplete);
    }

    public void OnSwipeSouth()
    {
        rayDirection = Vector3.back;
        if (hit.collider != null)
            transform.DOMoveZ(-distance, duration).SetEase(Ease.Linear).OnComplete(OnComplete);
    }

    public void OnSwipeWest()
    {
        rayDirection = Vector3.left;
        if (hit.collider != null)
            transform.DOMoveX(-distance, duration).SetEase(Ease.Linear).OnComplete(OnComplete);
    }

    public void OnSwipeEast()
    {
        rayDirection = Vector3.right;
        if (hit.collider != null)
            transform.DOMoveX(distance, duration).SetEase(Ease.Linear).OnComplete(OnComplete);
    }

    private void OnComplete()
    {
        transform.DOMove(new Vector3(0, 0, 0), 0.50f);
    }

    RaycastHit hit;
    void CheckEnemy()
    {
        if (Physics.Raycast(transform.position, rayDirection, out hit, 50, LayerMask.GetMask("Enemy")))
        { Debug.DrawRay(transform.position, rayDirection, Color.white); }
    }
}
