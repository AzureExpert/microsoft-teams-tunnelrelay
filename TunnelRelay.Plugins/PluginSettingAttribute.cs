﻿// <copyright file="PluginSettingAttribute.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace TunnelRelay.PluginEngine
{
    using System;

    /// <summary>
    /// Plugin settings.
    /// </summary>
    /// <seealso cref="Attribute" />
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class PluginSettingAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginSettingAttribute"/> class.
        /// </summary>
        /// <param name="displayName">The display name to be shown to user..</param>
        /// <param name="helpText">The help text to be shown on hover..</param>
        public PluginSettingAttribute(string displayName, string helpText)
        {
            this.DisplayName = displayName;
            this.HelpText = helpText;
        }

        /// <summary>
        /// Gets the display name.
        /// </summary>
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets the help text.
        /// </summary>
        public string HelpText { get; private set; }
    }
}
