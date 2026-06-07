<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Sentry

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.sentry)](https://github.com/GameFrameX/com.gameframex.unity.sentry/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.sentry)](https://github.com/GameFrameX/com.gameframex.unity.sentry/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使

<br />

[文檔](https://gameframex.doc.alianblank.com) · [快速開始](#快速開始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>
## 語言

[English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

---

## 項目簡介

本插件是 [GameFrameX](https://github.com/GameFrameX/GameFrameX) 框架的 Sentry 日誌上報模組，用於將 Unity 專案的日誌資訊即時上報到 Sentry 平台，幫助開發者監控和分析遊戲執行狀態。

## 功能特性

- **多級別日誌上報** - 支援 Debug、Info、Warning、Error、Fatal 五個日誌級別的上報
- **時間戳標記** - 自動為每條日誌新增 Unity 時間戳，便於問題追蹤
- **GameFramework 整合** - 完美整合 GameFramework 日誌系統，實現無縫日誌上報
- **程式碼防裁剪** - 使用 `[Preserve]` 特性防止 Unity 程式碼裁剪導致的異常
- **輕量級實作** - 簡潔高效的日誌輔助器實作，不影響遊戲效能

## 快速開始

### 安裝方式（任選其一）

1. **Package Manager（推薦）**：開啟 Unity 的 Package Manager（Window -> Package Manager），點選 `+`，選擇 "Add package from git URL..."，輸入：
   ```
   https://github.com/gameframex/com.gameframex.unity.sentry.git
   ```

2. **manifest.json**：在專案的 `Packages/manifest.json` 檔案中新增依賴：
   ```json
   {
     "dependencies": {
       "com.gameframex.unity.sentry": "https://github.com/gameframex/com.gameframex.unity.sentry.git"
     }
   }
   ```

3. **本機安裝**：將本倉庫複製或下載到本機，將整個 `com.gameframex.unity.sentry` 資料夾複製到專案的 `Packages` 目錄下。

## 使用範例

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

        // 現在所有的日誌都會自動上報到 Sentry
        Log.Debug("遊戲啟動成功");
        Log.Info("玩家登入: {0}", playerName);
        Log.Warning("網路延遲較高: {0}ms", latency);
        Log.Error("載入資源失敗: {0}", assetPath);
        Log.Fatal("嚴重錯誤，遊戲即將退出");
    }
}
```

### 日誌級別說明

| 日誌級別 | Sentry 對應級別 | 使用場景 |
|---------|----------------|----------|
| Debug | Info | 除錯資訊，開發階段使用 |
| Info | Info | 一般資訊，正常執行日誌 |
| Warning | Warning | 警告資訊，非致命問題 |
| Error | Error | 錯誤資訊，功能異常 |
| Fatal | Fatal | 致命錯誤，程式無法繼續執行 |

## 平台支援

| 平台    | 支援 |
|---------|------|
| iOS     | 是   |
| Android | 是   |
| Windows | 是   |
| macOS   | 是   |
| WebGL   | 是   |

## 依賴說明

- **com.gameframex.unity**: 1.1.1 或更高版本 - GameFramework 核心框架
- **io.sentry.unity**: 4.0.0 或更高版本 - Sentry Unity SDK

## 更新日誌

詳見 [CHANGELOG.md](CHANGELOG.md)。

## 開源協議

本專案採用 MIT 協議開源，詳見 [LICENSE.md](LICENSE.md) 檔案。
