using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSaber : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void TriggerBeam()
    {
        bool isOn = animator.GetBool("LightSaberOn");
        animator.SetBool("LightSaberOn", !isOn);
    }
}
