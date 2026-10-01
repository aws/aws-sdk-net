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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The theme configuration. This configuration contains all of the display properties
    /// for a theme.
    /// </summary>
    public partial class ThemeConfiguration
    {
        /// <summary>
        /// Gets and sets the property DataColorPalette. 
        /// <para>
        /// Color properties that apply to chart data colors.
        /// </para>
        /// </summary>
        public DataColorPalette DataColorPalette { get; set; }

        /// <summary>
        /// Checks to see if the DataColorPalette property is set.
        /// </summary>
        internal bool IsSetDataColorPalette() => this.DataColorPalette != null;

        /// <summary>
        /// Gets and sets the property Sheet. 
        /// <para>
        /// Display options related to sheets.
        /// </para>
        /// </summary>
        public SheetStyle Sheet { get; set; }

        /// <summary>
        /// Checks to see if the Sheet property is set.
        /// </summary>
        internal bool IsSetSheet() => this.Sheet != null;

        /// <summary>
        /// Gets and sets the property Typography.
        /// </summary>
        public Typography Typography { get; set; }

        /// <summary>
        /// Checks to see if the Typography property is set.
        /// </summary>
        internal bool IsSetTypography() => this.Typography != null;

        /// <summary>
        /// Gets and sets the property UIColorPalette. 
        /// <para>
        /// Color properties that apply to the UI and to charts, excluding the colors that apply
        /// to data. 
        /// </para>
        /// </summary>
        public UIColorPalette UIColorPalette { get; set; }

        /// <summary>
        /// Checks to see if the UIColorPalette property is set.
        /// </summary>
        internal bool IsSetUIColorPalette() => this.UIColorPalette != null;
    }
}
