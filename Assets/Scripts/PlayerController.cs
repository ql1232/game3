 using UnityEngine;

 public class Player : MonoBehaviour
 {
 [SerializeField] private InputManager inputManager;
 [SerializeField] private float speed;
private int time = 0;

[SerializeField] private bool b = false;
 private Rigidbody rb;

 private void Start()
 {
 //Adding MovePlayer as a listener to the OnMove event
 inputManager.OnMove.AddListener(MovePlayer);
inputManager.OnJump.AddListener(JumpPlayer);

 rb = GetComponent<Rigidbody>();
 }

 //This is similar to our code from our Roll-A-Ball tutorial
 //Only difference being, we only listen to Left and Right inputs
 private void MovePlayer(Vector3 direction)
 {
Vector3 pos = transform.position;
if(!Physics.CapsuleCast(transform.position,pos, 0.5F,new Vector3(0,-1,0),1, 1)){
 rb.AddForce(2F * direction);
}else{
 rb.AddForce(4 * direction);}
}
 private void JumpPlayer()
 {
	Vector3 pos = transform.position;
	pos.y-=0.5F;
b=Physics.CapsuleCast(transform.position,pos, 0.5F,new Vector3(0,-1,0),1, 1);
  if(b&&time==0){
   rb.AddForce(new Vector3(0,300,0));
	time=300;
  }
}
public void Update(){
 if(time>0){
	time--;
}
}

}