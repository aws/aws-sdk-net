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
    /// The field options for a pivot table visual.
    /// </summary>
    public partial class PivotTableFieldOptions
    {
        private List<PivotTableDataPathOption> _dataPathOptions = new List<PivotTableDataPathOption>();
        private List<PivotTableFieldOption> _selectedFieldOptions = new List<PivotTableFieldOption>();

        /// <summary>
        /// Gets and sets the property DataPathOptions. 
        /// <para>
        /// The data path options for the pivot table field options.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<PivotTableDataPathOption> DataPathOptions
        {
            get { return this._dataPathOptions; }
            set { this._dataPathOptions = value; }
        }

        // Check to see if DataPathOptions property is set
        internal bool IsSetDataPathOptions()
        {
            return this._dataPathOptions != null && this._dataPathOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SelectedFieldOptions. 
        /// <para>
        /// The selected field options for the pivot table field options.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<PivotTableFieldOption> SelectedFieldOptions
        {
            get { return this._selectedFieldOptions; }
            set { this._selectedFieldOptions = value; }
        }

        // Check to see if SelectedFieldOptions property is set
        internal bool IsSetSelectedFieldOptions()
        {
            return this._selectedFieldOptions != null && this._selectedFieldOptions.Count > 0; 
        }

    }
}