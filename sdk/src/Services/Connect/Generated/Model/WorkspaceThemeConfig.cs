/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains detailed theme configuration for a workspace, including colors, images, and
    /// typography.
    /// </summary>
    public partial class WorkspaceThemeConfig
    {
        private WorkspaceThemeImages _images;
        private WorkspaceThemePalette _palette;
        private WorkspaceThemeTypography _typography;

        /// <summary>
        /// Gets and sets the property Images. 
        /// <para>
        /// The image assets used in the workspace theme.
        /// </para>
        /// </summary>
        public WorkspaceThemeImages Images
        {
            get { return this._images; }
            set { this._images = value; }
        }

        // Check to see if Images property is set
        internal bool IsSetImages()
        {
            return this._images != null;
        }

        /// <summary>
        /// Gets and sets the property Palette. 
        /// <para>
        /// The color palette configuration for the workspace theme.
        /// </para>
        /// </summary>
        public WorkspaceThemePalette Palette
        {
            get { return this._palette; }
            set { this._palette = value; }
        }

        // Check to see if Palette property is set
        internal bool IsSetPalette()
        {
            return this._palette != null;
        }

        /// <summary>
        /// Gets and sets the property Typography. 
        /// <para>
        /// The typography configuration for the workspace theme.
        /// </para>
        /// </summary>
        public WorkspaceThemeTypography Typography
        {
            get { return this._typography; }
            set { this._typography = value; }
        }

        // Check to see if Typography property is set
        internal bool IsSetTypography()
        {
            return this._typography != null;
        }

    }
}