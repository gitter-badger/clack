document.getElementById("heading").innerHTML =
    localStorage["title"] || "Heading"; //default text
document.getElementById("texteditor").innerHTML = 
    localStorage["Text"] || "Type some text!"; //default text
setInterval(saveFn() {
    //Autosave Function
    localStorage["title"] = document.getElementById("heading").innerHTML;
    localStorage["Text"] = document.getElementById("texteditor").innerHTML;
}, 1000);