
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "DeadZone")
        {
            Destroy(gameObject, 0);
        }
    }
}
