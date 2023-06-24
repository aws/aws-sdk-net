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
    /// A <i>sheet</i>, which is an object that contains a set of visuals that are viewed
    /// together on one page in Amazon QuickSight. Every analysis and dashboard contains at
    /// least one sheet. Each sheet contains at least one visualization widget, for example
    /// a chart, pivot table, or narrative insight. Sheets can be associated with other components,
    /// such as controls, filters, and so on.
    /// </summary>
    public partial class Sheet
    {
        private string _name;
        private string _sheetId;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a sheet. This name is displayed on the sheet's tab in the Amazon QuickSight
        /// console.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SheetId. 
        /// <para>
        /// The unique identifier associated with a sheet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string SheetId
        {
            get { return this._sheetId; }
            set { this._sheetId = value; }
        }

        // Check to see if SheetId property is set
        internal bool IsSetSheetId()
        {
            return this._sheetId != null;
        }

    }
}