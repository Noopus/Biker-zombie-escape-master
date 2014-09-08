/*
This camera smoothes out rotation around the y-axis and height.
Horizontal Distance to the target is always fixed.

There are many different ways to smooth the rotation but doing it this way gives you a lot of control over how the camera behaves.

For every of those smoothed values we calculate the wanted value and the current value.
Then we smooth it using the Lerp function.
Then we apply the smoothed values to the transform's position.
*/

// The target we are following
var target : Transform;
// The distance in the x-z plane to the target
var distance = 10.0;
// the height we want the camera to be above the target
var height = 5.0;
// How much we 
var heightDamping = 2.0;
var rotationDamping = 3.0;

// Place the script in the Camera-Control group in the component menu
@script AddComponentMenu("Camera-Control/Smooth Follow")


function Start()
{


	
}

var counter:int;


	var degrees=0;


	var goleft;

var goright;


var follow;

var iPx:float;

function LateUpdate () {
	// Early out if we don't have a target
	
	
	
	counter=Time.time;
	
	
	if (!target)
		return;
	
	
	
	
	// Calculate the current rotation angles
	var wantedRotationAngle = target.eulerAngles.y;
	var wantedHeight = target.position.y + height;
		
	var currentRotationAngle = transform.eulerAngles.y;
	var currentHeight = transform.position.y;
	
	// Damp the rotation around the y-axis
	currentRotationAngle = Mathf.LerpAngle (currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);

	// Damp the height
	currentHeight = Mathf.Lerp (currentHeight, wantedHeight, heightDamping * Time.deltaTime);

	// Convert the angle into a rotation
	var currentRotation = Quaternion.Euler (0, currentRotationAngle, 0);
	
	// Set the position of the camera on the x-z plane to:
	// distance meters behind the target
//	transform.position = target.position;
	
	
	
//	transform.position -= currentRotation * Vector3.forward * distance;

	// Set the height of the camera
//	transform.position.y = currentHeight;
	
	// Always look at the target
	
	
		if (Input.GetKey (KeyCode.K)||iPx>0.3f) {
			goleft = true;
			goright = false;
			
		} else
		if (Input.GetKey (KeyCode.L)||iPx<-0.3f) {
			goleft = false;
			goright = true;
			
		} else {
			goleft=false;
			goright=false;
			
		}



/*



	//	if (Input.GetKey (KeyCode.K)) {
		if(goleft)
		{

						this.transform.Translate (Vector3.left * (0.1f+degrees));
			
						//	transform.RotateAround (target.position, Vector3.down, degrees * Time.deltaTime);
						degrees += 0.005f;
			
				} else
			
//		if (Input.GetKey (KeyCode.L)) {
			if(goright)
		{

						this.transform.Translate (-Vector3.left * (0.1f+degrees));

						degrees += 0.005f;

						//		transform.RotateAround (target.position, Vector3.forward, -degrees * Time.deltaTime);

				} else {
			degrees=0;
				}

*/

if(target.transform.position.x>-3.5f&&target.transform.position.x<3.5f)
{
follow=true;
}
else
{
follow=false;
}

if(follow==false)
{
/*
if(this.transform.position.x<0)
{
  this.transform.position.x=-2.8f;
}
else
if(this.transform.position.x>0)
{
  this.transform.position.x=2.8f;
}
*/


}

if(follow)
this.transform.position.x=target.transform.position.x;


//print("cam x : "+this.transform.position.x);

	
	
//	transform.LookAt (target);
	
	
	
	
}