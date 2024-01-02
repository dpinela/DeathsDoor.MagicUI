using System;
using UnityEngine;

namespace MagicUI.Core
{
    /// <summary>
    /// Class containing various UI utilities and constants
    /// </summary>
    public static class UI
    {
        /// <summary>
        /// A rectangle representing the screen
        /// </summary>
        public static readonly Rect Screen = new(Vector2.zero, new Vector2(1920, 1080));

        /// <summary>
        /// The Miso font
        /// </summary>
        public static Font Miso {
            get {
                if (miso == null)
                {
                    miso = GetFont("Miso");
                }
                return miso;
            }
        }

        /// <summary>
        /// The Trajan Normal font
        /// </summary>
        public static Font TrajanNormal => Miso;

        /// <summary>
        /// The Trajan Bold font
        /// </summary>
        public static Font TrajanBold => Miso;

        /// <summary>
        /// The Perpetua font
        /// </summary>
        public static Font Perpetua => Miso;

        private static Font? miso;

        private static Font GetFont(string name)
        {
            foreach (var f in Resources.FindObjectsOfTypeAll<Font>())
            {
                if (f != null && f.name == name)
                {
                    return f;
                }
            }
            throw new InvalidOperationException($"{name} font not found");
        }

        /// <summary>
        /// Converts a position in reference screen space to a unity position
        /// </summary>
        /// <param name="pos">The position in screen space</param>
        /// <param name="elementSize">The size of the element</param>
        /// <remarks>
        /// Reference screen space is the coordinate system with (0, 0) in the top-left and
        /// (1920, 1080) in the bottom-right.
        /// </remarks>
        public static Vector2 UnityScreenPosition(Vector2 pos, Vector2 elementSize)
        {
            return UnityParentRelativePosition(pos, elementSize, Screen.size);
        }

        /// <summary>
        /// Converts a position in parent space to a unity position
        /// </summary>
        /// <param name="pos">The position in parent space</param>
        /// <param name="elementSize">The size of the element</param>
        /// <param name="parentSize">The size of the element's parent</param>
        /// <remarks>
        /// Parent space is the coordinate system with (0, 0) in the top-left and
        /// (W, H) in the bottom-right, where W is the width of the parent and H is the height
        /// of the parent
        /// </remarks>
        public static Vector2 UnityParentRelativePosition(Vector2 pos, Vector2 elementSize, Vector2 parentSize)
        {
            return new((pos.x + elementSize.x / 2f) / parentSize.x,
                   (parentSize.y - (pos.y + elementSize.y / 2f)) / parentSize.y);
        }
    }
}
