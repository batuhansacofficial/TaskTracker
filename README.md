# Task Tracker

## Description
A command-line task tracker built with C# and .NET.<br>
Project Idea: [Task Tracker](https://roadmap.sh/projects/task-tracker)

## Features
- Add a task
- Update a task
- Delete a task
- Change task status
- List tasks with status

## Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## Getting Started

### Clone or Download the Repository

```bash
git clone https://github.com/batuhansacofficial/TaskTracker.git
```
or download the ZIP file and extract it.

### Build and Run the Application

1. Restore the Dependencies:
```bash
dotnet restore
```

2. Build the application:
```bash
dotnet build
```

3. Run the application:
```bash
dotnet run
```

## Commands
### Add a Task
```bash
dotnet run add "Modify the description here"
```
### Update a Task
```bash
dotnet run update <task-id> "Modify the description here"
```
### Delete a task
```bash
dotnet run delete <task-id>
```
### Change Task Status
```bash
dotnet run mark-in-progress <task-id>
```
```bash
dotnet run mark-done <task-id>
```
### List tasks with status
```bash
dotnet run list <status>
```
- (`<status>` is optional and can be *todo*, *in-progress* or *done*)

## Viewing Task Data
Tasks are stored in `tasks.json`.

## Common Issues
If you encounter issues with the `tasks.json` file, delete it, and the application will create a new one.

## Contributing
Contributions are welcome! Please open an issue or submit a pull request for any changes.

## License
This project is licensed under the MIT License. See the [LICENSE](https://github.com/batuhansacofficial/TaskTracker?tab=MIT-1-ov-file) file for details.