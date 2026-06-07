<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Sentry

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.sentry)](https://github.com/GameFrameX/com.gameframex.unity.sentry/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.sentry)](https://github.com/GameFrameX/com.gameframex.unity.sentry/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使

<br />

[文档](https://gameframex.doc.alianblank.com) · [快速开始](#快速开始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 语言

[English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

---

## 项目简介

本插件是 [GameFrameX](https://github.com/GameFrameX/GameFrameX) 框架的 Sentry 日志上报模块，用于将 Unity 项目的日志信息实时上报到 Sentry 平台，帮助开发者监控和分析游戏运行状态。

## 功能特性

- **多级别日志上报** - 支持 Debug、Info、Warning、Error、Fatal 五个日志级别的上报
- **时间戳标记** - 自动为每条日志添加 Unity 时间戳，便于问题追踪
- **GameFramework 集成** - 完美集成 GameFramework 日志系统，实现无缝日志上报
- **代码防裁剪** - 使用 `[Preserve]` 特性防止 Unity 代码裁剪导致的异常
- **轻量级实现** - 简洁高效的日志辅助器实现，不影响游戏性能

## 快速开始

### 安装

选择以下任一方式：

1. 编辑 Unity 项目的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：
   ```json
   {
     "scopedRegistries": [
       {
         "name": "GameFrameX",
         "url": "https://gameframex.upm.alianblank.uk",
         "scopes": [
           "com.gameframex"
         ]
       }
     ],
     "dependencies": {
       "com.gameframex.unity.sentry": "1.1.1"
     }
   }
   ```

   `scopes` 控制哪些包通过此注册表解析。只有以 `com.gameframex` 开头的包才会从这个注册表获取。

2. 直接在 `manifest.json` 的 `dependencies` 节点下添加以下内容：
   ```json
   {
      "com.gameframex.unity.sentry": "https://github.com/gameframex/com.gameframex.unity.sentry.git"
   }
   ```
3. 在 Unity 的 `Package Manager` 中使用 `Git URL` 的方式添加库，地址为：`https://github.com/gameframex/com.gameframex.unity.sentry.git`
4. 直接下载仓库放置到 Unity 项目的 `Packages` 目录下，会自动加载识别。
## 使用示例

### 初始化 SentryLogHelper

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

### 日志级别说明

| 日志级别 | Sentry 对应级别 | 使用场景 |
|---------|----------------|----------|
| Debug | Info | 调试信息，开发阶段使用 |
| Info | Info | 一般信息，正常运行日志 |
| Warning | Warning | 警告信息，非致命问题 |
| Error | Error | 错误信息，功能异常 |
| Fatal | Fatal | 致命错误，程序无法继续运行 |

## 平台支持

| 平台    | 支持 |
|---------|------|
| iOS     | 是   |
| Android | 是   |
| Windows | 是   |
| macOS   | 是   |
| WebGL   | 是   |

## 依赖说明

- **com.gameframex.unity**: 1.1.1 或更高版本 - GameFramework 核心框架
- **io.sentry.unity**: 4.0.0 或更高版本 - Sentry Unity SDK

## 更新日志

详见 [CHANGELOG.md](CHANGELOG.md)。


## 依赖

| 包 | 说明 |
|----|------|
| `com.gameframex.unity` | 1.1.1 |
| `io.sentry.unity` | 4.0.0 |

## 文档与资源

- [官方文档](https://gameframex.doc.alianblank.com)

## 社区与支持

- QQ群: 467608841 / 233840761
## 开源协议

详见 [LICENSE.md](LICENSE.md) 文件。
