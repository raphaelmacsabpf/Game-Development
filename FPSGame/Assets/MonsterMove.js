#pragma strict

var speed : Vector3 = Vector3(1, 1, 1);

var CharacterDetected : boolean = false;

 

function OnTriggerEnter(object : Collider)

{

    if(object.transform.name == "Player")
	print("MAOHEE");
    CharacterDetected = true;

}

 

function OnTriggerExit(object : Collider)

{

    if(object.transform.name == "Player")

    CharacterDetected = false;

}

 

function Update()

{

    if(CharacterDetected || true)

        {

        var x : float = gameObject.Find("Player").transform.position.x + 1;

        var y : float = gameObject.Find("Player").transform.position.y;

        var z : float = gameObject.Find("Player").transform.position.z + 1;

        speed = Vector3(x, y, z);

        transform.rigidbody.MovePosition(gameObject.Find("Player").transform.position + speed * Time.deltaTime);

    }

}