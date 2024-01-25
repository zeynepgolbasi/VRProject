using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Unity.XR.CoreUtils;


[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(XROrigin))]
public class RoomScaleFix : MonoBehaviour
{
    private CharacterController _character;
    private XROrigin _xrOrigin;

    void Start()
    {
        //gerekli bileþenleri aldýk
        _character = GetComponent<CharacterController>();
        _xrOrigin = GetComponent<XROrigin>();
    }
    void FixedUpdate()
    {
        //karakter yükesekliði ayarla
        _character.height = _xrOrigin.CameraInOriginSpaceHeight + 0.15f;

        //karakter merkezi ayarla
        var centerPoint = transform.InverseTransformPoint(_xrOrigin.Camera.transform.position);
        _character.center = new Vector3(
            centerPoint.x,
            _character.height / 2 + _character.skinWidth,
            centerPoint.z);
        //karakteri hareket ettir
        _character.Move(new Vector3(0.001f, -0.001f, 0.001f));
        _character.Move(new Vector3(-0.001f, -0.001f, -0.001f));


    }


}
