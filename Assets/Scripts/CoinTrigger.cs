using System;
 using UnityEngine;
 using UnityEngine.Events;

 public class CoinTrigger : MonoBehaviour
 {

 public UnityEvent OnCoinCollect = new();
 private void OnTriggerEnter(Collider triggeredObject)
 {
	OnCoinCollect.Invoke();
	Destroy(gameObject);
 }
 }