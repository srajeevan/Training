<!DOCTYPE html>
<html>
<body>

<h1>JavaScript Tutorial</h1>

<p>Hi Sreejith Here</p>

<p id="demo1"></p>
<p id="demo2"></p>
<p id="demo3"></P>
<p id="demo4"></p>
<script>
var x = 5;
var y = 6;
var d = "IMCS Training"
var student={firstname:"Mike",lastname:"smith",age:45};
var z = x + y;
function myfunc(x1,x2) {
return x1 * x2;
}
document.getElementById("demo1").innerHTML = z;
document.getElementById("demo2").innerHTML = myfunc(3,5);
document.getElementById("demo3").innerHTML = student.firstname;
<button onclick="this.innerHTML=Date()">The time is?</button>
<button onclick = "document.getElementById('demo4').innerHTML = Date()">The time is?</button>

</script>

</body>
</html>


