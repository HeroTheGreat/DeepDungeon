using UnityEngine;

public class EnemyKill : MonoBehaviour
{
    public BoxCollider cube;
    private void OnTriggerExit(Collider other)
    {
        if (cube)
        {
            Destroy(gameObject);
        }
    }
}
