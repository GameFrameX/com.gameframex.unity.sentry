<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Sentry

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.sentry)](https://github.com/GameFrameX/com.gameframex.unity.sentry/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.sentry)](https://github.com/GameFrameX/com.gameframex.unity.sentry/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현

<br />

[문서](https://gameframex.doc.alianblank.com) · [빠른 시작](#빠른-시작) · QQ 그룹: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**

</div>

## 언어

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**

---

## 프로젝트 개요

이 플러그인은 [GameFrameX](https://github.com/GameFrameX/GameFrameX) 프레임워크의 Sentry 로그 보고 모듈입니다. Unity 프로젝트의 로그 정보를 Sentry 플랫폼에 실시간으로 보고하여 개발자가 게임 실행 상태를 모니터링하고 분석할 수 있도록 도와줍니다.

## 기능

- **다중 레벨 로그 보고** - Debug, Info, Warning, Error, Fatal 5개 로그 레벨 지원
- **타임스탬프 마킹** - 각 로그 항목에 Unity 타임스탬프를 자동 추가하여 문제 추적 용이
- **GameFramework 통합** - GameFramework 로그 시스템과 원활하게 통합
- **코드 스트리핑 방지** - `[Preserve]` 속성을 사용하여 Unity 코드 스트리핑 문제 방지
- **경량 구현** - 성능에 영향을 주지 않는 효율적인 로그 헬퍼 구현

## 빠른 시작

### 설치

Unity 프로젝트의 `Packages/manifest.json`을 편집하여 `scopedRegistries` 섹션을 추가하세요:

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
  ]
}
```

`scopes`는 이 레지스트리를 통해 어떤 패키지를 해석할지 제어합니다. `com.gameframex`로 시작하는 패키지만 이 레지스트리에서 가져옵니다.

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.sentry": "1.1.1"
  }
}
```


## 사용 예시

### SentryLogHelper 초기화

```csharp
using GameFrameX;
using GameFrameX.SentryLog.Runtime;

public class GameEntry : MonoBehaviour
{
    private void Start()
    {
        // GameFramework 초기화
        GameFrameworkEntry.GetSingleton<GameFrameworkLog>().SetLogHelper(new SentryLogHelper());

        // 이제 모든 로그가 자동으로 Sentry에 보고됩니다
        Log.Debug("게임 시작 성공");
        Log.Info("플레이어 로그인: {0}", playerName);
        Log.Warning("네트워크 지연 높음: {0}ms", latency);
        Log.Error("에셋 로드 실패: {0}", assetPath);
        Log.Fatal("치명적 오류, 게임이 종료됩니다");
    }
}
```

### 로그 레벨

| 로그 레벨 | Sentry 레벨 | 사용 사례 |
|-----------|-------------|----------|
| Debug | Info | 디버그 정보, 개발 단계 |
| Info | Info | 일반 정보, 정상 동작 로그 |
| Warning | Warning | 경고 정보, 치명적이지 않은 문제 |
| Error | Error | 오류 정보, 기능 장애 |
| Fatal | Fatal | 치명적 오류, 프로그램 계속 불가 |

## 플랫폼 지원

| 플랫폼  | 지원 |
|---------|------|
| iOS     | 예   |
| Android | 예   |
| Windows | 예   |
| macOS   | 예   |
| WebGL   | 예   |

## 종속성

- **com.gameframex.unity**: 1.1.1+ - GameFramework 코어
- **io.sentry.unity**: 4.0.0+ - Sentry Unity SDK

## 변경 로그

자세한 내용은 [CHANGELOG.md](CHANGELOG.md)를 참조하세요.

## 라이선스

이 프로젝트는 MIT 라이선스에 따라 배포됩니다. 자세한 내용은 [LICENSE.md](LICENSE.md) 파일을 참조하세요.
