[English](README.md) | [日本語](README.ja.md)

# Process Killer

A tool to periodically kill specified processes.

## Usage

Set the target processes, build the solution with Visual Studio, and use the generated executable file.

When the tool is launched, specified processes are periodically killed until terminated.
To terminate the tool, kill the process from Task Manager.

### Setting Target Process

Set the filenames of the target processes to kill.

```csharp
private static readonly string[] ProcessFileNames =
{
    "notepad.exe",
};
```

### Setting Interval

Set the interval as needed. The default interval is 5 seconds.

```csharp
private static readonly TimeSpan Interval = TimeSpan.FromSeconds(5);
```

## License

This software is licensed under the [Unlicense](LICENSE).
