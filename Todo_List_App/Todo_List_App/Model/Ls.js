import { readFile, writeFile } from 'jsonfile';

const createTaskButton = document.getElementById("createTask");
createTaskButton.addEventListener("click", createNewTask());
function createNewTask() {
    var x = Date.now();
    var taskPriority = document.getElementById("taskPriority").value;
    var taskDescription = document.getElementById("taskDescription").value;
    const newTask = {
        "name": taskPriority,
        "description": taskDescription,
        "date": x,
        "status": false
    };
    
    const file = '../todos.json';
    readFile(file, (err, data) => {
        if (err) throw err;
        let tasks = JSON.parse(data);
        tasks.push(newTask);
        writeFile(file, JSON.stringify(tasks), (err) => {
            if (err) throw err;
            console.log('Data written to file');
        });
    });
}


/*
function addTaskToJSON(task) {
    var newTask = JSON.stringify(task);
    fs.appendFile('../todos.json', newTask, err => {
        //error handling
        if (err) throw err;
        console.log('Task added to JSON file');
    });
}
*/