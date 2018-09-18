//this was an old script dedicated to destroying apples, now integrated into the spawn script

#pragma strict

var apple : GameObject;

var Seconds = 10;

function Start () {

}


 function Update(){
     Destroy();
 }
 
 function Destroy(){
     yield WaitForSeconds(Seconds);
     Destroy(apple);
 }