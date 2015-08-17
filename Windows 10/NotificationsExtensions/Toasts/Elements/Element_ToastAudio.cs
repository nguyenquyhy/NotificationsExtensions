// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved


using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
#if !WINRT_NOT_PRESENT
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
#endif
using System.Reflection;
using System.Linq;
using System.Collections;
using System.IO;

namespace NotificationsExtensions.Toasts
{
    [NotificationXmlElement("audio")]
    internal sealed class Element_ToastAudio
    {
        internal const bool DEFAULT_LOOP = false;
        internal const bool DEFAULT_SILENT = false;

        /// <summary>
        /// The media file to play in place of the default sound. This can either be a ms-winsoundevent value, or a custom ms-appx:/// or ms-appdata:/// file, or null for the default sound.
        /// </summary>
        [NotificationXmlAttribute("src")]
        public Uri Src { get; set; }

        [NotificationXmlAttribute("loop", DEFAULT_LOOP)]
        public bool Loop { get; set; } = DEFAULT_LOOP;

        /// <summary>
        /// True to mute the sound; false to allow the toast notification sound to play.
        /// </summary>
        [NotificationXmlAttribute("silent", DEFAULT_SILENT)]
        public bool Silent { get; set; } = DEFAULT_SILENT;
    }
}