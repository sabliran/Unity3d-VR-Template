﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionController : MonoBehaviour
{
    public XRController leftTeleportRay;
    public XRController rightTeleportRay;
    public InputHelpers.Button TeleportActivationButton;
    public float activationThreshold = 0.1f;




    void Update()
    {
        if (leftTeleportRay)
        {
            leftTeleportRay.gameObject.SetActive(CheckIfActivated(leftTeleportRay));
        }

        if (rightTeleportRay)
        {
            rightTeleportRay.gameObject.SetActive(CheckIfActivated(rightTeleportRay));
        }



    }

    public bool CheckIfActivated(XRController controller)
    { 
        InputHelpers.IsPressed(controller.inputDevice, TeleportActivationButton, out bool isActivated, activationThreshold);
        return isActivated;
    }


}
