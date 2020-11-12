using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astraInput : MonoBehaviour
{
    private Animator astraAnimator = null;
    private float verticalPress;
    
    // Start is called before the first frame update
    void Start()
    {
        astraAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalPress = Input.GetAxis("Vertical");
        astraAnimator.SetFloat("Blend", verticalPress);
    }
}
