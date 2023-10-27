//import { createNewTask } from "../Model/Ls.js";
import { displayCreateTaskForm } from "DisplayHelpers.js";

var x = document.getElementById("createTaskButton");
x.addEventListener("click", loadCreateView);

function loadCreateView() {
    window.location = '../views/Create.html';
}


