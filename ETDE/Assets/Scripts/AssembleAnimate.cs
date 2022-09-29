using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssembleAnimate : MonoBehaviour
{
    private Animator Anim;

    // Use this for initialization
    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AnimExplode()
    {
        Anim.Play("open", -1, 0f);
        Anim.speed = 0.5f;
    }

    public void AnimAssemble()
    {
        Anim.Play("close", -1, 0f);
        Anim.speed = 0.5f;
    }

    public void AnimRunning()
    {
        Anim.Play("running", -1, 0f);
        Anim.speed = 0.5f;
    }
}
