using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    [SerializeField] Animator _anim;

    public void ChangeAnimation()
    {
        _anim.SetInteger("State", Random.RandomRange(1, 4));
    }
}
