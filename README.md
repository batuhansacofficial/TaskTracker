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

### Build the Application
```bash
dotnet build
```

## Commands
- **Add a task**:
```bash
dotnet run add "Modify the description here"
```
- **Update a task**:
```bash
dotnet run update <task-id> "Modify the description here"
```
- **Delete a task**:
```bash
dotnet run delete <task-id>
```
- **Change task status**:
```bash
dotnet run mark-in-progress <task-id>
```
```bash
dotnet run mark-done <task-id>
```
- **List tasks with status (optional)**: 
```bash
dotnet run list <status>
```
(`<status>` is optional and can be *todo*, *in-progress* or *done*)

## Viewing Task Data
Tasks are stored in `tasks.json`.

## Common Issues
- If you encounter issues with the `tasks.json` file, delete it, and the application will create a new one.

https://roadmap.sh/projects/task-tracker
