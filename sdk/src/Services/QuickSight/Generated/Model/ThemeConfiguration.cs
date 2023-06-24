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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The theme configuration. This configuration contains all of the display properties
    /// for a theme.
    /// </summary>
    public partial class ThemeConfiguration
    {
        private DataColorPalette _dataColorPalette;
        private SheetStyle _sheet;
        private Typography _typography;
        private UIColorPalette _uiColorPalette;

        /// <summary>
        /// Gets and sets the property DataColorPalette. 
        /// <para>
        /// Color properties that apply to chart data colors.
        /// </para>
        /// </summary>
        public DataColorPalette DataColorPalette
        {
            get { return this._dataColorPalette; }
            set { this._dataColorPalette = value; }
        }

        // Check to see if DataColorPalette property is set
        internal bool IsSetDataColorPalette()
        {
            return this._dataColorPalette != null;
        }

        /// <summary>
        /// Gets and sets the property Sheet. 
        /// <para>
        /// Display options related to sheets.
        /// </para>
        /// </summary>
        public SheetStyle Sheet
        {
            get { return this._sheet; }
            set { this._sheet = value; }
        }

        // Check to see if Sheet property is set
        internal bool IsSetSheet()
        {
            return this._sheet != null;
        }

        /// <summary>
        /// Gets and sets the property Typography.
        /// </summary>
        public Typography Typography
        {
            get { return this._typography; }
            set { this._typography = value; }
        }

        // Check to see if Typography property is set
        internal bool IsSetTypography()
        {
            return this._typography != null;
        }

        /// <summary>
        /// Gets and sets the property UIColorPalette. 
        /// <para>
        /// Color properties that apply to the UI and to charts, excluding the colors that apply
        /// to data. 
        /// </para>
        /// </summary>
        public UIColorPalette UIColorPalette
        {
            get { return this._uiColorPalette; }
            set { this._uiColorPalette = value; }
        }

        // Check to see if UIColorPalette property is set
        internal bool IsSetUIColorPalette()
        {
            return this._uiColorPalette != null;
        }

    }
}