<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Sentry

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.sentry)](https://github.com/GameFrameX/com.gameframex.unity.sentry/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.sentry)](https://github.com/GameFrameX/com.gameframex.unity.sentry/releases)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams

<br />

[Documentation](https://gameframex.doc.alianblank.com) · [Quick Start](#quick-start) · [QQ Group](https://qm.qq.com/q/5U9Fvebw)

<br />

**English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>
## Language

**English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

---

## Project Overview

This plugin is the Sentry log reporting module for the [GameFrameX](https://github.com/GameFrameX/GameFrameX) framework. It reports Unity project log information to the Sentry platform in real-time, helping developers monitor and analyze game runtime status.

## Features

- **Multi-level Log Reporting** - Supports Debug, Info, Warning, Error, and Fatal log levels
- **Timestamp Marking** - Automatically adds Unity timestamps to each log entry for issue tracking
- **GameFramework Integration** - Seamlessly integrates with the GameFramework logging system
- **Code Stripping Prevention** - Uses `[Preserve]` attribute to prevent Unity code stripping issues
- **Lightweight Implementation** - Efficient log helper implementation with minimal performance impact

## Quick Start

### Installation (choose one)

1. **Package Manager (Recommended)**: Open Unity's Package Manager (Window -> Package Manager), click `+`, select "Add package from git URL...", and enter:
   ```
   https://github.com/gameframex/com.gameframex.unity.sentry.git
   ```

2. **manifest.json**: Add to `Packages/manifest.json`:
   ```json
   {
     "dependencies": {
       "com.gameframex.unity.sentry": "https://github.com/gameframex/com.gameframex.unity.sentry.git"
     }
   }
   ```

3. **Local**: Clone the repository and place the `com.gameframex.unity.sentry` folder in the project's `Packages` directory.

## Usage Examples

### Initialize SentryLogHelper

```csharp
using GameFrameX;
using GameFrameX.SentryLog.Runtime;

public class GameEntry : MonoBehaviour
{
    private void Start()
    {
        // Initialize GameFramework
        GameFrameworkEntry.GetSingleton<GameFrameworkLog>().SetLogHelper(new SentryLogHelper());

        // Now all logs will be automatically reported to Sentry
        Log.Debug("Game started successfully");
        Log.Info("Player logged in: {0}", playerName);
        Log.Warning("High network latency: {0}ms", latency);
        Log.Error("Failed to load asset: {0}", assetPath);
        Log.Fatal("Critical error, game will exit");
    }
}
```

### Log Levels

| Log Level | Sentry Level | Use Case |
|-----------|-------------|----------|
| Debug | Info | Debug info, development phase |
| Info | Info | General info, normal operation logs |
| Warning | Warning | Warning info, non-fatal issues |
| Error | Error | Error info, feature malfunction |
| Fatal | Fatal | Fatal error, program cannot continue |

## Platform Support

| Platform | Supported |
|----------|-----------|
| iOS      | Yes       |
| Android  | Yes       |
| Windows  | Yes       |
| macOS    | Yes       |
| WebGL    | Yes       |

## Dependencies

- **com.gameframex.unity**: 1.1.1+ - GameFramework core
- **io.sentry.unity**: 4.0.0+ - Sentry Unity SDK

## Changelog

See [CHANGELOG.md](CHANGELOG.md) for details.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
