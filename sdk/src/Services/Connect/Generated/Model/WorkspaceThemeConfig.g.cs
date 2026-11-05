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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Images. 
        /// <para>
        /// The image assets used in the workspace theme.
        /// </para>
        /// </summary>
        public WorkspaceThemeImages Images { get; set; }

        /// <summary>
        /// Checks to see if the Images property is set.
        /// </summary>
        internal bool IsSetImages() => this.Images != null;

        /// <summary>
        /// Gets and sets the property Palette. 
        /// <para>
        /// The color palette configuration for the workspace theme.
        /// </para>
        /// </summary>
        public WorkspaceThemePalette Palette { get; set; }

        /// <summary>
        /// Checks to see if the Palette property is set.
        /// </summary>
        internal bool IsSetPalette() => this.Palette != null;

        /// <summary>
        /// Gets and sets the property Typography. 
        /// <para>
        /// The typography configuration for the workspace theme.
        /// </para>
        /// </summary>
        public WorkspaceThemeTypography Typography { get; set; }

        /// <summary>
        /// Checks to see if the Typography property is set.
        /// </summary>
        internal bool IsSetTypography() => this.Typography != null;
    }
}
