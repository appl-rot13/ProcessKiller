[English](README.md) | [日本語](README.ja.md)

# Process Killer

定期的に指定したプロセスを強制終了するツール。

## 使い方

対象プロセスを設定してVisual Studioでビルドし、出力されたexeファイルを使用します。

ツールを起動すると、終了するまで定期的に指定したプロセスの強制終了を施行します。  
ツールを終了したい場合、タスクマネージャーからプロセスを強制終了してください。

### 対象プロセスの設定

対象プロセスのファイル名を指定します。

```csharp
private static readonly string[] ProcessFileNames =
{
    "notepad.exe",
};
```

### インターバルの設定

必要に応じてインターバルを設定します。デフォルトは5秒です。

```csharp
private static readonly TimeSpan Interval = TimeSpan.FromSeconds(5);
```

## ライセンス

このソフトウェアは[Unlicense](LICENSE)に基づいてライセンスされています。
