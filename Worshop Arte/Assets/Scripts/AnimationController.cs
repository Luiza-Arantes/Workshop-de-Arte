using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        ps = GetComponent<ParticleSystem>();

    }

    public void TriggerAnimation()
    {
        animator.SetTrigger("pulo");
    }
}
