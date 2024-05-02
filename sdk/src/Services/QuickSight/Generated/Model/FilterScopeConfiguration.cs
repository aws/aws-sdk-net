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
    /// The scope configuration for a <c>FilterGroup</c>.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class FilterScopeConfiguration
    {
        private AllSheetsFilterScopeConfiguration _allSheets;
        private SelectedSheetsFilterScopeConfiguration _selectedSheets;

        /// <summary>
        /// Gets and sets the property AllSheets. 
        /// <para>
        /// The configuration that applies a filter to all sheets. When you choose <c>AllSheets</c>
        /// as the value for a <c>FilterScopeConfiguration</c>, this filter is applied to all
        /// visuals of all sheets in an Analysis, Dashboard, or Template. The <c>AllSheetsFilterScopeConfiguration</c>
        /// is chosen.
        /// </para>
        /// </summary>
        public AllSheetsFilterScopeConfiguration AllSheets
        {
            get { return this._allSheets; }
            set { this._allSheets = value; }
        }

        // Check to see if AllSheets property is set
        internal bool IsSetAllSheets()
        {
            return this._allSheets != null;
        }

        /// <summary>
        /// Gets and sets the property SelectedSheets. 
        /// <para>
        /// The configuration for applying a filter to specific sheets.
        /// </para>
        /// </summary>
        public SelectedSheetsFilterScopeConfiguration SelectedSheets
        {
            get { return this._selectedSheets; }
            set { this._selectedSheets = value; }
        }

        // Check to see if SelectedSheets property is set
        internal bool IsSetSelectedSheets()
        {
            return this._selectedSheets != null;
        }

    }
}