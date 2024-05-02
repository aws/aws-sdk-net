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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
    /// Themes in Amazon QuickSight</a> in the <i>Amazon QuickSight User Guide.</i>
    /// </summary>
    public partial class UIColorPalette
    {
        private string _accent;
        private string _accentForeground;
        private string _danger;
        private string _dangerForeground;
        private string _dimension;
        private string _dimensionForeground;
        private string _measure;
        private string _measureForeground;
        private string _primaryBackground;
        private string _primaryForeground;
        private string _secondaryBackground;
        private string _secondaryForeground;
        private string _success;
        private string _successForeground;
        private string _warning;
        private string _warningForeground;

        /// <summary>
        /// Gets and sets the property Accent. 
        /// <para>
        /// This color is that applies to selected states and buttons.
        /// </para>
        /// </summary>
        public string Accent
        {
            get { return this._accent; }
            set { this._accent = value; }
        }

        // Check to see if Accent property is set
        internal bool IsSetAccent()
        {
            return this._accent != null;
        }

        /// <summary>
        /// Gets and sets the property AccentForeground. 
        /// <para>
        /// The foreground color that applies to any text or other elements that appear over the
        /// accent color.
        /// </para>
        /// </summary>
        public string AccentForeground
        {
            get { return this._accentForeground; }
            set { this._accentForeground = value; }
        }

        // Check to see if AccentForeground property is set
        internal bool IsSetAccentForeground()
        {
            return this._accentForeground != null;
        }

        /// <summary>
        /// Gets and sets the property Danger. 
        /// <para>
        /// The color that applies to error messages.
        /// </para>
        /// </summary>
        public string Danger
        {
            get { return this._danger; }
            set { this._danger = value; }
        }

        // Check to see if Danger property is set
        internal bool IsSetDanger()
        {
            return this._danger != null;
        }

        /// <summary>
        /// Gets and sets the property DangerForeground. 
        /// <para>
        /// The foreground color that applies to any text or other elements that appear over the
        /// error color.
        /// </para>
        /// </summary>
        public string DangerForeground
        {
            get { return this._dangerForeground; }
            set { this._dangerForeground = value; }
        }

        // Check to see if DangerForeground property is set
        internal bool IsSetDangerForeground()
        {
            return this._dangerForeground != null;
        }

        /// <summary>
        /// Gets and sets the property Dimension. 
        /// <para>
        /// The color that applies to the names of fields that are identified as dimensions.
        /// </para>
        /// </summary>
        public string Dimension
        {
            get { return this._dimension; }
            set { this._dimension = value; }
        }

        // Check to see if Dimension property is set
        internal bool IsSetDimension()
        {
            return this._dimension != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionForeground. 
        /// <para>
        /// The foreground color that applies to any text or other elements that appear over the
        /// dimension color.
        /// </para>
        /// </summary>
        public string DimensionForeground
        {
            get { return this._dimensionForeground; }
            set { this._dimensionForeground = value; }
        }

        // Check to see if DimensionForeground property is set
        internal bool IsSetDimensionForeground()
        {
            return this._dimensionForeground != null;
        }

        /// <summary>
        /// Gets and sets the property Measure. 
        /// <para>
        /// The color that applies to the names of fields that are identified as measures.
        /// </para>
        /// </summary>
        public string Measure
        {
            get { return this._measure; }
            set { this._measure = value; }
        }

        // Check to see if Measure property is set
        internal bool IsSetMeasure()
        {
            return this._measure != null;
        }

        /// <summary>
        /// Gets and sets the property MeasureForeground. 
        /// <para>
        /// The foreground color that applies to any text or other elements that appear over the
        /// measure color.
        /// </para>
        /// </summary>
        public string MeasureForeground
        {
            get { return this._measureForeground; }
            set { this._measureForeground = value; }
        }

        // Check to see if MeasureForeground property is set
        internal bool IsSetMeasureForeground()
        {
            return this._measureForeground != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryBackground. 
        /// <para>
        /// The background color that applies to visuals and other high emphasis UI.
        /// </para>
        /// </summary>
        public string PrimaryBackground
        {
            get { return this._primaryBackground; }
            set { this._primaryBackground = value; }
        }

        // Check to see if PrimaryBackground property is set
        internal bool IsSetPrimaryBackground()
        {
            return this._primaryBackground != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryForeground. 
        /// <para>
        /// The color of text and other foreground elements that appear over the primary background
        /// regions, such as grid lines, borders, table banding, icons, and so on.
        /// </para>
        /// </summary>
        public string PrimaryForeground
        {
            get { return this._primaryForeground; }
            set { this._primaryForeground = value; }
        }

        // Check to see if PrimaryForeground property is set
        internal bool IsSetPrimaryForeground()
        {
            return this._primaryForeground != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryBackground. 
        /// <para>
        /// The background color that applies to the sheet background and sheet controls.
        /// </para>
        /// </summary>
        public string SecondaryBackground
        {
            get { return this._secondaryBackground; }
            set { this._secondaryBackground = value; }
        }

        // Check to see if SecondaryBackground property is set
        internal bool IsSetSecondaryBackground()
        {
            return this._secondaryBackground != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryForeground. 
        /// <para>
        /// The foreground color that applies to any sheet title, sheet control text, or UI that
        /// appears over the secondary background.
        /// </para>
        /// </summary>
        public string SecondaryForeground
        {
            get { return this._secondaryForeground; }
            set { this._secondaryForeground = value; }
        }

        // Check to see if SecondaryForeground property is set
        internal bool IsSetSecondaryForeground()
        {
            return this._secondaryForeground != null;
        }

        /// <summary>
        /// Gets and sets the property Success. 
        /// <para>
        /// The color that applies to success messages, for example the check mark for a successful
        /// download.
        /// </para>
        /// </summary>
        public string Success
        {
            get { return this._success; }
            set { this._success = value; }
        }

        // Check to see if Success property is set
        internal bool IsSetSuccess()
        {
            return this._success != null;
        }

        /// <summary>
        /// Gets and sets the property SuccessForeground. 
        /// <para>
        /// The foreground color that applies to any text or other elements that appear over the
        /// success color.
        /// </para>
        /// </summary>
        public string SuccessForeground
        {
            get { return this._successForeground; }
            set { this._successForeground = value; }
        }

        // Check to see if SuccessForeground property is set
        internal bool IsSetSuccessForeground()
        {
            return this._successForeground != null;
        }

        /// <summary>
        /// Gets and sets the property Warning. 
        /// <para>
        /// This color that applies to warning and informational messages.
        /// </para>
        /// </summary>
        public string Warning
        {
            get { return this._warning; }
            set { this._warning = value; }
        }

        // Check to see if Warning property is set
        internal bool IsSetWarning()
        {
            return this._warning != null;
        }

        /// <summary>
        /// Gets and sets the property WarningForeground. 
        /// <para>
        /// The foreground color that applies to any text or other elements that appear over the
        /// warning color.
        /// </para>
        /// </summary>
        public string WarningForeground
        {
            get { return this._warningForeground; }
            set { this._warningForeground = value; }
        }

        // Check to see if WarningForeground property is set
        internal bool IsSetWarningForeground()
        {
            return this._warningForeground != null;
        }

    }
}