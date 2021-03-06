// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved


using System;

namespace NotificationsExtensions.Toasts
{

    /// <summary>
    /// Specify audio to be played when the toast notification is received.
    /// </summary>
    public sealed class ToastAudio
    {
        /// <summary>
        /// The media file to play in place of the default sound.
        /// </summary>
        public Uri Src { get; set; }

        /// <summary>
        /// Set to true if the sound should repeat as long as the toast is shown; false to play only once (default).
        /// </summary>
        public bool Loop { get; set; } = Element_ToastAudio.DEFAULT_LOOP;

        /// <summary>
        /// True to mute the sound; false to allow the toast notification sound to play (default).
        /// </summary>
        public bool Silent { get; set; } = Element_ToastAudio.DEFAULT_SILENT;

        internal Element_ToastAudio ConvertToElement()
        {
            return new Element_ToastAudio()
            {
                Src = Src,
                Loop = Loop,
                Silent = Silent
            };
        }
    }


}
