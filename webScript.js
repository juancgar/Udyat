
function readTextFile(file, callback) {
    var rawFile = new XMLHttpRequest();
    rawFile.overrideMimeType("application/json");
    rawFile.open("GET", file, true);
    rawFile.onreadystatechange = function() {
        if (rawFile.readyState === 4 && rawFile.status == "200") {
            callback(rawFile.responseText);
        }
    }
    rawFile.send(null);
}

readTextFile("C:\Users\Carlos\Desktop\github\Udyat\data.json", function(text){
    var data = JSON.parse(text);
	console.log(data);
});
var info = data;
//Situation of the event detected
var label;

//Date of the event
var date;

//Location of the event
var location;

//path of the video-event
var videoPath;

$(document).ready(function(){
	label = document.getElementById("label");
	//location = document.getElementById("location-text");
	//date = document.getElementById("time-text");

	label.innerHTML = "2";


	
	//date.innerHTML = newData[0].date;
})
