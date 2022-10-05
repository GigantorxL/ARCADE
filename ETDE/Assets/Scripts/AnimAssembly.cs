using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimAssembly : MonoBehaviour
{
    private Animator Anim;

    void Start ()
    {
        Anim = GetComponent<Animator>();
        Anim.speed = 0f;

    }

    public void AnimExplode()
    {
        Anim.Play("explode", -1, 0f);
        Anim.speed = 0.5f;
    }

    public void AnimAssemble()
    {
        Anim.Play("assemble", -1, 0f);
        Anim.speed = 0.5f;
    }
}
