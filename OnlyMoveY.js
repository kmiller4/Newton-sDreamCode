#pragma strict

//var X_PositionLockedAt : float ; //locking the position at a certain value for X
//var Z_PositionLockedAt : float ; //locking the position at a certain value for Z

var X_RotationLockedAt : int ; //locking the rotation at a certain angle for X
var Y_RotationLockedAt : int ; //locking the rotation at a certain angle for Y
var Z_RotationLockedAt : int ; //locking the rotation at a certain angle for Z

 
function Update()
{
     transform.rotation = Quaternion.Euler(X_RotationLockedAt, Y_RotationLockedAt, Z_RotationLockedAt);
     //transform.position.x = X_PositionLockedAt;
     //transform.position.z = Z_PositionLockedAt;
}