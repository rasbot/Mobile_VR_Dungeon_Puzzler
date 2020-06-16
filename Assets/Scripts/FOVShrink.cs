using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class FOVShrink : MonoBehaviour {
    public float simulatedFOV;

    public float IPD;
    public float SCREEN_DISTANCE;

    public VignetteAndChromaticAberration[] fovControls;

	// Update is called once per frame
	void Update () {
        float maxFOV = Mathf.Rad2Deg * Mathf.Atan2(IPD / 2f, SCREEN_DISTANCE);
        foreach (VignetteAndChromaticAberration fov in fovControls)
            fov.intensity = 1f - Mathf.Clamp01(simulatedFOV / maxFOV);		
	}
}
