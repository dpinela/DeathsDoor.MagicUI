using BepInEx;
using System;

namespace MagicUI
{
    /// <summary>
    /// Base mod class
    /// </summary>
    [BepInPlugin("deathsdoor.magicui", "MagicUI", "1.8")]
    public class MagicUIMod : BaseUnityPlugin
    {
        private static MagicUIMod? instance;
        internal static MagicUIMod Instance
        {
            get
            {
                if (instance == null)
                {
                    throw new InvalidOperationException($"{nameof(MagicUIMod)} was never initialized!");
                }
                return instance;
            }
            private set => instance = value;
        }

        /// <summary>
        /// Instantiates the mod instance
        /// </summary>
        public MagicUIMod()
        {
            Instance = this;
        }

        internal void LogDebug(string msg)
        {
            Logger.LogDebug(msg);
        }
    }
}