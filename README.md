# GameFrameX Unity Sentry 日志上报插件

本插件是 [GameFrameX](https://github.com/GameFrameX/GameFrameX) 框架的 Sentry 日志上报模块，用于将 Unity 项目的日志信息实时上报到 Sentry 平台，帮助开发者监控和分析游戏运行状态。

## 功能特性

- **多级别日志上报** - 支持 Debug、Info、Warning、Error、Fatal 五个日志级别的上报
- **时间戳标记** - 自动为每条日志添加 Unity 时间戳，便于问题追踪
- **GameFramework 集成** - 完美集成 GameFramework 日志系统，实现无缝日志上报
- **代码防裁剪** - 使用 `[Preserve]` 特性防止 Unity 代码裁剪导致的异常
- **轻量级实现** - 简洁高效的日志辅助器实现，不影响游戏性能

## 安装方式

### 方式一：通过 Package Manager 安装（推荐）

1. 打开 Unity 的 Package Manager（Window -> Package Manager）
2. 点击左上角的 `+` 按钮，选择 "Add package from git URL..."
3. 输入以下地址并点击 Add：
```
https://github.com/gameframex/com.gameframex.unity.sentry.git
```

### 方式二：通过 manifest.json 安装

在项目的 `Packages/manifest.json` 文件中添加依赖：
```json
{
  "dependencies": {
    "com.gameframex.unity.sentry": "https://github.com/gameframex/com.gameframex.unity.sentry.git",
    // ... 其他依赖
  }
}
```

### 方式三：本地安装

1. 将本仓库克隆或下载到本地
2. 将整个 `com.gameframex.unity.sentry` 文件夹复制到项目的 `Packages` 目录下
3. Unity 会自动识别并加载该插件

## 快速开始

### 1. 配置 Sentry

确保你的 Unity 项目已经集成了 Sentry SDK。如果还没有集成，请先安装 Sentry Unity 插件。

### 2. 初始化 SentryLogHelper

在你的游戏初始化代码中添加 Sentry 日志辅助器：

```csharp
using GameFrameX;
using GameFrameX.SentryLog.Runtime;

public class GameEntry : MonoBehaviour
{
    private void Start()
    {
        // 初始化 GameFramework
        GameFrameworkEntry.GetSingleton<GameFrameworkLog>().SetLogHelper(new SentryLogHelper());
        
        // 现在所有的日志都会自动上报到 Sentry
        Log.Debug("游戏启动成功");
        Log.Info("玩家登录: {0}", playerName);
        Log.Warning("网络延迟较高: {0}ms", latency);
        Log.Error("加载资源失败: {0}", assetPath);
        Log.Fatal("严重错误，游戏即将退出");
    }
}
```

### 3. 使用示例

```csharp
using GameFrameX;

public class GameManager : MonoBehaviour
{
    private void StartGame()
    {
        // 普通信息日志
        Log.Info("游戏开始，玩家ID: {0}", playerId);
        
        // 警告日志
        if (networkLatency > 200)
        {
            Log.Warning("网络延迟警告: {0}ms", networkLatency);
        }
        
        // 错误日志
        try
        {
            // 某些可能出错的操作
            LoadGameData();
        }
        catch (Exception ex)
        {
            Log.Error("加载游戏数据失败: {0}", ex.Message);
        }
        
        // 致命错误
        if (criticalError)
        {
            Log.Fatal("游戏遇到致命错误，需要重启");
        }
    }
}
```

## 日志级别说明

| 日志级别 | Sentry 对应级别 | 使用场景 |
|---------|----------------|----------|
| Debug | Info | 调试信息，开发阶段使用 |
| Info | Info | 一般信息，正常运行日志 |
| Warning | Warning | 警告信息，非致命问题 |
| Error | Error | 错误信息，功能异常 |
| Fatal | Fatal | 致命错误，程序无法继续运行 |

## 高级配置

### 自定义日志格式

`SentryLogHelper` 会自动为每条日志添加时间戳前缀，格式为：
```
[Unity]:[HH:mm:ss.fff]: 你的日志内容
```

### 与 GameFramework 日志系统集成

本插件实现了 `GameFrameworkLog.ILogHelper` 接口，完美集成到 GameFramework 的日志系统中。所有通过 GameFramework 的日志 API 输出的日志都会自动上报到 Sentry。

### 代码保护

插件使用了 `[UnityEngine.Scripting.Preserve]` 特性，确保在 Unity 的代码裁剪过程中不会被意外移除，保证日志功能的稳定性。

## 依赖说明

- **com.gameframex.unity**: 1.1.1 或更高版本 - GameFramework 核心框架
- **Sentry Unity SDK**: 需要单独安装，用于实际的日志上报功能

## 兼容性

- **Unity 版本**: 2017.1 及以上版本
- **平台支持**: 全平台支持（iOS、Android、Windows、macOS、WebGL 等）
- **.NET 版本**: 与 Unity 的 .NET Standard 2.0 兼容

## 更新日志

详见 [CHANGELOG.md](CHANGELOG.md) 文件

## 许可证

本项目采用 MIT 许可证，详见 [LICENSE.md](LICENSE.md) 文件

## 支持与贡献

- **官方文档**: https://gameframex.doc.alianblank.com/
- **GitHub 仓库**: https://github.com/gameframex/com.gameframex.unity.sentry
- **问题反馈**: 请在 GitHub Issues 中提交
- **功能建议**: 欢迎提交 Pull Request

## 注意事项

1. 确保在使用前已经正确配置了 Sentry SDK
2. 生产环境建议适当调整日志级别，避免过多的 Debug 日志影响性能
3. 敏感信息请不要通过日志输出，避免泄露到 Sentry 平台
4. 建议在正式发布前充分测试日志上报功能

---

**GameFrameX** - 独立游戏前后端一体化解决方案，独立游戏开发者的圆梦大使。