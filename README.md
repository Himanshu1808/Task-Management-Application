# Task-Management-Application
Developed a basic task management application using C# and .NET Framework. The application allows users to create, update, and delete tasks, as well as mark them as completed. Shown how GitHub Copilot can be used to generate code for implementing CRUD operations, input validation, and user interface design.

This code implements a basic task management application in C# and .NET Framework. It consists of a Task class representing a task with properties like Id, Title, Description, and IsCompleted. The TaskRepository class handles the CRUD operations, allowing tasks to be added, updated, and deleted. The Program class serves as the user interface, presenting a console menu for creating, updating, deleting, marking tasks as completed, and viewing all tasks. The application utilizes a List to store the tasks in memory. Users can interact with the application through the console interface, performing various task management operations.

The task management application is designed to help users organize and track their tasks. It allows users to perform several operations, including creating tasks, updating task details, marking tasks as completed, deleting tasks, and viewing all tasks.

The system comprises three main components:

Task Class: The Task class represents an individual task and contains properties like Id, Title, Description, and IsCompleted. These properties store information about the task, such as its unique identifier, title, description, and completion status.

TaskRepository Class: The TaskRepository class is responsible for managing the tasks. It uses a List<Task> to store the tasks in memory. This class provides methods for adding tasks, updating task details, deleting tasks, and retrieving all tasks.

Program Class: The Program class acts as the user interface for the task management application. It presents a console-based menu where users can choose various options. Based on the user's selection, the program invokes the corresponding methods from the TaskRepository class to perform the desired operations.

Here's a brief overview of how the application works:

1. The user launches the application, and the console menu is displayed.
2. The user selects an option from the menu, such as creating a task.
3. The application prompts the user to enter the task details like title and description.
4. Using the TaskRepository class, the application creates a new Task object with the provided details and adds it to the list of tasks.
5. The user can choose other options, such as updating or deleting a task, marking a task as completed, or viewing all tasks.
6. For each option, the application interacts with the TaskRepository class to perform the requested operation on the tasks.
7. The user can continue interacting with the application until they choose the option to exit.
