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
    /// The field options for a pivot table visual.
    /// </summary>
    public partial class PivotTableFieldOptions
    {
        private List<PivotTableFieldCollapseStateOption> _collapseStateOptions = AWSConfigs.InitializeCollections ? new List<PivotTableFieldCollapseStateOption>() : null;
        private List<PivotTableDataPathOption> _dataPathOptions = AWSConfigs.InitializeCollections ? new List<PivotTableDataPathOption>() : null;
        private List<PivotTableFieldOption> _selectedFieldOptions = AWSConfigs.InitializeCollections ? new List<PivotTableFieldOption>() : null;

        /// <summary>
        /// Gets and sets the property CollapseStateOptions. 
        /// <para>
        /// The collapse state options for the pivot table field options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PivotTableFieldCollapseStateOption> CollapseStateOptions
        {
            get { return this._collapseStateOptions; }
            set { this._collapseStateOptions = value; }
        }

        // Check to see if CollapseStateOptions property is set
        internal bool IsSetCollapseStateOptions()
        {
            return this._collapseStateOptions != null && (this._collapseStateOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataPathOptions. 
        /// <para>
        /// The data path options for the pivot table field options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._dataPathOptions != null && (this._dataPathOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SelectedFieldOptions. 
        /// <para>
        /// The selected field options for the pivot table field options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._selectedFieldOptions != null && (this._selectedFieldOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}