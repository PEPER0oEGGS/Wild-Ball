using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] private Animator _anim;
    [SerializeField] private GameObject _root;
    [SerializeField] private float _destroyTime = 0.5f;

    private void OnTriggerEnter(Collider other)
    {
        _anim.SetTrigger("Collect");
        Destroy(_root, _destroyTime);
    }


}
