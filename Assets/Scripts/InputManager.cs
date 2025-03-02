using System;
using UnityEngine;
using Unity.Cinemachine;

using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
[SerializeField] private CinemachineCamera freeLookCamera;
public UnityEvent OnSpacePressed = new UnityEvent();
public UnityEvent<Vector3> OnMove = new UnityEvent<Vector3>();
public UnityEvent OnJump = new UnityEvent();
public UnityEvent OnResetPressed = new UnityEvent();
void Update()
{
if (Input.GetKeyDown(KeyCode.Space))
{
OnSpacePressed?.Invoke();
}
Vector3 input = Vector3.zero;
if (Input.GetKey(KeyCode.A))
 {
 input += Vector3.Normalize(freeLookCamera.transform.right*-1);
 }
 if (Input.GetKey(KeyCode.D))
 {
 input += Vector3.Normalize(freeLookCamera.transform.right);
 }
if (Input.GetKey(KeyCode.W))
 {
	Vector3 v = freeLookCamera.transform.forward;
	v.y=0;
 input += Vector3.Normalize(v);
 }
if (Input.GetKey(KeyCode.S))
 {
Vector3 v = freeLookCamera.transform.forward;
	v.y=0;
 input += Vector3.Normalize(v*-1);
 }
if (Input.GetKey(KeyCode.Space))
{
 OnJump.Invoke();
}
 OnMove?.Invoke(input);
}
}	