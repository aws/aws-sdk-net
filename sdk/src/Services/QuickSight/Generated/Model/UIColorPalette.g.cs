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
    /// The theme colors that apply to UI and to charts, excluding data colors. The colors
    /// description is a hexadecimal color code that consists of six alphanumerical characters,
    /// prefixed with <c>#</c>, for example #37BFF5. For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/themes-in-quicksight.html">Using
    /// Themes in Quick Sight</a> in the <i>Quick Sight User Guide.</i>
    /// </summary>
    public partial class UIColorPalette
    {
        /// <summary>
        /// Gets and sets the property Accent. 
        /// <para>
        /// This color is that applies to selected states and buttons.
        /// </para>
        /// </summary>
        public string Accent { get; set; }

        /// <summary>
        /// Checks to see if the Accent property is set.
        /// </summary>
        internal bool IsSetAccent() => this.Accent != null;

        /// <summary>
        /// Gets and sets the property AccentForeground. 
        /// <para>
        /// The foreground color that applies to any text or other elements that appear over the
        /// accent color.
        /// </para>
        /// </summary>
        public string AccentForeground { get; set; }

        /// <summary>
        /// Checks to see if the AccentForeground property is set.
        /// </summary>
        internal bool IsSetAccentForeground() => this.AccentForeground != null;

        /// <summary>
        /// Gets and sets the property Danger. 
        /// <para>
        /// The color that applies to error messages.
        /// </para>
        /// </summary>
        public string Danger { get; set; }

        /// <summary>
        /// Checks to see if the Danger property is set.
        /// </summary>
        internal bool IsSetDanger() => this.Danger != null;

        /// <summary>
        /// Gets and sets the property DangerForeground. 
        /// <para>
        /// The foreground color that applies to any text or other elements that appear over the
        /// error color.
        /// </para>
        /// </summary>
        public string DangerForeground { get; set; }

        /// <summary>
        /// Checks to see if the DangerForeground property is set.
        /// </summary>
        internal bool IsSetDangerForeground() => this.DangerForeground != null;

        /// <summary>
        /// Gets and sets the property Dimension. 
        /// <para>
        /// The color that applies to the names of fields that are identified as dimensions.
        /// </para>
        /// </summary>
        public string Dimension { get; set; }

        /// <summary>
        /// Checks to see if the Dimension property is set.
        /// </summary>
        internal bool IsSetDimension() => this.Dimension != null;

        /// <summary>
        /// Gets and sets the property DimensionForeground. 
        /// <para>
        /// The foreground color that applies to any text or other elements that appear over the
        /// dimension color.
        /// </para>
        /// </summary>
        public string DimensionForeground { get; set; }

        /// <summary>
        /// Checks to see if the DimensionForeground property is set.
        /// </summary>
        internal bool IsSetDimensionForeground() => this.DimensionForeground != null;

        /// <summary>
        /// Gets and sets the property Measure. 
        /// <para>
        /// The color that applies to the names of fields that are identified as measures.
        /// </para>
        /// </summary>
        public string Measure { get; set; }

        /// <summary>
        /// Checks to see if the Measure property is set.
        /// </summary>
        internal bool IsSetMeasure() => this.Measure != null;

        /// <summary>
        /// Gets and sets the property MeasureForeground. 
        /// <para>
        /// The foreground color that applies to any text or other elements that appear over the
        /// measure color.
        /// </para>
        /// </summary>
        public string MeasureForeground { get; set; }

        /// <summary>
        /// Checks to see if the MeasureForeground property is set.
        /// </summary>
        internal bool IsSetMeasureForeground() => this.MeasureForeground != null;

        /// <summary>
        /// Gets and sets the property PrimaryBackground. 
        /// <para>
        /// The background color that applies to visuals and other high emphasis UI.
        /// </para>
        /// </summary>
        public string PrimaryBackground { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryBackground property is set.
        /// </summary>
        internal bool IsSetPrimaryBackground() => this.PrimaryBackground != null;

        /// <summary>
        /// Gets and sets the property PrimaryForeground. 
        /// <para>
        /// The color of text and other foreground elements that appear over the primary background
        /// regions, such as grid lines, borders, table banding, icons, and so on.
        /// </para>
        /// </summary>
        public string PrimaryForeground { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryForeground property is set.
        /// </summary>
        internal bool IsSetPrimaryForeground() => this.PrimaryForeground != null;

        /// <summary>
        /// Gets and sets the property SecondaryBackground. 
        /// <para>
        /// The background color that applies to the sheet background and sheet controls.
        /// </para>
        /// </summary>
        public string SecondaryBackground { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryBackground property is set.
        /// </summary>
        internal bool IsSetSecondaryBackground() => this.SecondaryBackground != null;

        /// <summary>
        /// Gets and sets the property SecondaryForeground. 
        /// <para>
        /// The foreground color that applies to any sheet title, sheet control text, or UI that
        /// appears over the secondary background.
        /// </para>
        /// </summary>
        public string SecondaryForeground { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryForeground property is set.
        /// </summary>
        internal bool IsSetSecondaryForeground() => this.SecondaryForeground != null;

        /// <summary>
        /// Gets and sets the property Success. 
        /// <para>
        /// The color that applies to success messages, for example the check mark for a successful
        /// download.
        /// </para>
        /// </summary>
        public string Success { get; set; }

        /// <summary>
        /// Checks to see if the Success property is set.
        /// </summary>
        internal bool IsSetSuccess() => this.Success != null;

        /// <summary>
        /// Gets and sets the property SuccessForeground. 
        /// <para>
        /// The foreground color that applies to any text or other elements that appear over the
        /// success color.
        /// </para>
        /// </summary>
        public string SuccessForeground { get; set; }

        /// <summary>
        /// Checks to see if the SuccessForeground property is set.
        /// </summary>
        internal bool IsSetSuccessForeground() => this.SuccessForeground != null;

        /// <summary>
        /// Gets and sets the property Warning. 
        /// <para>
        /// This color that applies to warning and informational messages.
        /// </para>
        /// </summary>
        public string Warning { get; set; }

        /// <summary>
        /// Checks to see if the Warning property is set.
        /// </summary>
        internal bool IsSetWarning() => this.Warning != null;

        /// <summary>
        /// Gets and sets the property WarningForeground. 
        /// <para>
        /// The foreground color that applies to any text or other elements that appear over the
        /// warning color.
        /// </para>
        /// </summary>
        public string WarningForeground { get; set; }

        /// <summary>
        /// Checks to see if the WarningForeground property is set.
        /// </summary>
        internal bool IsSetWarningForeground() => this.WarningForeground != null;
    }
}
