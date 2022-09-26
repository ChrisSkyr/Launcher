using System;

namespace Launcher
{
    [Serializable]
    public class LauncherConfig
    {
        public static LauncherConfig Instance;
        public static string VERSION_LINK = "https://drive.google.com/uc?export=download&id=1pes1miyomq1bP2de1-AzPY5FiBfJvN2W";
        public static string BUILD_LINK = "https://drive.google.com/uc?export=download&id=1Up1jSfDZ9mXFFJdxrq2DBnl1BWbAVPCm";
        public static string EXE_NAME = "ARModding Tool.exe";
        public bool IsAppRunning = false;
    }
}


