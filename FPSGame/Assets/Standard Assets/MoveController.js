var leader : Transform;
var follower : Transform;
var followerCC : CharacterController;
var toMove : int;
 
var speed : float =5; // The speed of the follower
 
function Start () {
	toMove = 0;
     followerCC = follower.GetComponent.<CharacterController>();
}
 
function Update(){
 
    follower.LookAt(leader);
    if(Vector3.Distance(this.gameObject.transform.position, leader.transform.position) > 2 && toMove != 0)
    {
    	followerCC.SimpleMove( follower.forward * speed );
    	comp = follower.GetComponent(Animator);
   		comp.SetFloat("speed", 15.0);	
   	}
   	else
   	{
   		comp = follower.GetComponent(Animator);
   		comp.SetFloat("speed", 0.0);
   	}
    //See character controller.SimpleMove().  Moves the object in that direction.
    //automatically multiplies by Time.deltaTime;
    //And responds to collisions
    //ignores vertical component of vector and uses built-in gravity instead. 
}