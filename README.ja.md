<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Sentry

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.sentry)](https://github.com/GameFrameX/com.gameframex.unity.sentry/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.sentry)](https://github.com/GameFrameX/com.gameframex.unity.sentry/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援

<br />

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#クイックスタート) · QQグループ: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

</div>

## 言語

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

---

## プロジェクト概要

このプラグインは [GameFrameX](https://github.com/GameFrameX/GameFrameX) フレームワークの Sentry ログ報告モジュールです。Unity プロジェクトのログ情報を Sentry プラットフォームにリアルタイムで報告し、開発者がゲームの実行状態を監視・分析できるようにします。

## 機能

- **マルチレベルログ報告** - Debug、Info、Warning、Error、Fatal の5つのログレベルをサポート
- **タイムスタンプマーク** - 各ログエントリにUnityタイムスタンプを自動追加し、問題追跡を容易に
- **GameFramework 統合** - GameFramework ログシステムとシームレスに統合
- **コードストリッピング防止** - `[Preserve]` 属性を使用して Unity のコードストリッピング問題を防止
- **軽量実装** - パフォーマンスに影響を与えない効率的なログヘルパー実装

## クイックスタート

### インストール（いずれかを選択）

1. **Package Manager（推奨）**：Unity の Package Manager（Window -> Package Manager）を開き、`+` をクリックし、「Add package from git URL...」を選択して以下を入力：
   ```
   https://github.com/gameframex/com.gameframex.unity.sentry.git
   ```

2. **manifest.json**：`Packages/manifest.json` に追加：
   ```json
   {
     "dependencies": {
       "com.gameframex.unity.sentry": "https://github.com/gameframex/com.gameframex.unity.sentry.git"
     }
   }
   ```

3. **ローカル**：リポジトリをクローンし、`com.gameframex.unity.sentry` フォルダをプロジェクトの `Packages` ディレクトリに配置します。

## 使用例

### SentryLogHelper の初期化

```csharp
using GameFrameX;
using GameFrameX.SentryLog.Runtime;

public class GameEntry : MonoBehaviour
{
    private void Start()
    {
        // GameFramework を初期化
        GameFrameworkEntry.GetSingleton<GameFrameworkLog>().SetLogHelper(new SentryLogHelper());

        // すべてのログが自動的に Sentry に報告されます
        Log.Debug("ゲーム起動成功");
        Log.Info("プレイヤーログイン: {0}", playerName);
        Log.Warning("ネットワーク遅延が高い: {0}ms", latency);
        Log.Error("アセットの読み込みに失敗: {0}", assetPath);
        Log.Fatal("重大なエラー、ゲームが終了します");
    }
}
```

### ログレベル

| ログレベル | Sentry レベル | 使用場面 |
|-----------|-------------|----------|
| Debug | Info | デバッグ情報、開発段階 |
| Info | Info | 一般情報、通常動作ログ |
| Warning | Warning | 警告情報、致命的でない問題 |
| Error | Error | エラー情報、機能障害 |
| Fatal | Fatal | 致命的エラー、プログラム継続不可 |

## プラットフォーム対応

| プラットフォーム | 対応 |
|------------------|------|
| iOS              | はい |
| Android          | はい |
| Windows          | はい |
| macOS            | はい |
| WebGL            | はい |

## 依存関係

- **com.gameframex.unity**: 1.1.1+ - GameFramework コア
- **io.sentry.unity**: 4.0.0+ - Sentry Unity SDK

## 変更履歴

詳細は [CHANGELOG.md](CHANGELOG.md) をご覧ください。

## ライセンス

このプロジェクトは MIT ライセンスの下で公開されています。詳細は [LICENSE.md](LICENSE.md) ファイルをご覧ください。
