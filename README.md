# Task Tracker

## Description
A command-line task tracker built with C# and .NET.

## Requirements
- **.NET SDK (version)**: 8.0.400
- **Target Framework**: .NET 8.0 
- **Visual Studio** or **Visual Studio Code** (optional)

## Getting Started

### Clone or Download the Repository
```bash
git clone https://github.com/batuhansacofficial/TaskTracker/
```
or download the ZIP file and extract it.

### Navigate to Project Directory
```bash
cd path/to/TaskTracker
```

### Restore Dependencies
```bash
dotnet restore
```

### Run the Application
```bash
dotnet run
```

## Commands
- **Add a task**: `dotnet run add "Task Description"`
- **Update a task**: `dotnet run update <task-id> "New Task Description"`
- **Delete a task**: `dotnet run delete <task-id>`
- **Change task status**: `dotnet run mark-in-progress <task-id>` or `dotnet run mark-done <task-id>`
- **List tasks with status (optional)**: `dotnet run list <status> (optional)` (`<status> (optional)` can be *todo*, *in-progress* or *done*)

## Viewing Task Data
Tasks are stored in `tasks.json`.

## Common Issues
- If you encounter issues with the `tasks.json` file, delete it, and the application will create a new one.

https://roadmap.sh/projects/task-tracker
