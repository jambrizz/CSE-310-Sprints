// This JavaScript file contains helper functions for displaying the todo list.

function displayCreateTaskForm() {
    const createForm = document.getElementById("createTaskForm");
    createForm.innerHTML = '';
    let form = document.createElement("form");
    form.classList.add('forms');
    form.setAttribute("id", "createForm");
    createForm.appendChild(form);

    let label = document.createElement("label");
    label.setAttribute("for", "taskPriority");
    label.innerHTML = "Task Priority: ";
    form.appendChild(label);

    let dropdown = document.createElement("select");
    dropdown.setAttribute("id", "taskPriority");
    dropdown.setAttribute("name", "taskPriority");
    form.appendChild(dropdown);
    let option1 = document.createElement("option");
    option1.setAttribute("value", "High");
    option1.innerHTML = "High"; 
    dropdown.appendChild(option1);
    let option2 = document.createElement("option");
    option2.setAttribute("value", "Medium");
    option2.innerHTML = "Medium";
    dropdown.appendChild(option2);
    let option3 = document.createElement("option");
    option3.setAttribute("value", "Low");
    option3.innerHTML = "Low";
    dropdown.appendChild(option3);
    let br = document.createElement("br");
    form.appendChild(br);

    let label2 = document.createElement("label");
    label2.setAttribute("for", "taskDescription");
    label2.innerHTML = "Task Description: ";
    form.appendChild(label2);
    let input = document.createElement("input");
    input.setAttribute("type", "text");
    input.setAttribute("id", "taskDescription");
    input.setAttribute("name", "taskDescription");
    input.setAttribute("placeholder", "Enter task description here...")
    input.setAttribute("required", "true");
    input.setAttribute("maxlength", "75");
    form.appendChild(input);

    let divButtons = document.createElement("div");
    divButtons.setAttribute("id", "divButtons");
    form.appendChild(divButtons);
    let createButton = document.createElement("button");
    createButton.innerHTML = "Create Task";
    createButton.setAttribute("id", "createTask");
    divButtons.appendChild(createButton);
    let cancelButton = document.createElement("button");
    cancelButton.innerHTML = "Cancel";
    cancelButton.setAttribute("id", "cancel");
    divButtons.appendChild(cancelButton);
    form.appendChild(divButtons);
}

displayCreateTaskForm();