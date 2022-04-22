using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OculusHandImplementation : MonoBehaviour
{

    public InputActionReference _gripPress;
    public InputActionReference _triggerPress;
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        _gripPress.action.performed += GripStarted;
        _gripPress.action.canceled += GripCanceled;

        _triggerPress.action.performed += TriggerStarted;
        _triggerPress.action.canceled += TriggerCanceled;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GripStarted(InputAction.CallbackContext ctx)
    {
        anim.SetFloat("Grip", ctx.ReadValue<float>());
    }

    void GripCanceled(InputAction.CallbackContext ctx)
    {
        anim.SetFloat("Grip", 0f);
    }

    //Trigger

    void TriggerStarted(InputAction.CallbackContext ctx)
    {
        anim.SetFloat("Trigger", ctx.ReadValue<float>());
    }

    void TriggerCanceled(InputAction.CallbackContext ctx)
    {
        anim.SetFloat("Trigger", 0f);
    }

}
