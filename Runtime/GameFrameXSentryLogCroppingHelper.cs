using UnityEngine;
using UnityEngine.Scripting;

namespace GameFrameX.SentryLog.Runtime
{
    [Preserve]
    public class GameFrameXSentryLogCroppingHelper : MonoBehaviour
    {
        [Preserve]
        private void Start()
        {
            _ = typeof(GameFrameX.SentryLog.Runtime.SentryLogHelper);
        }
    }
}