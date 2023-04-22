using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class LightController : MonoBehaviour
{
    [SerializeField] Light lightSrc;

    public bool lightOn = false;
    private CharacterController charController;

    // Start is called before the first frame update
    void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)) lightOn = !lightOn;
        if (lightOn == true) lightSrc.intensity = 2;
        else lightSrc.intensity = 0;
    }
}
