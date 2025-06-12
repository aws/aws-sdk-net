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
    /// The configuration of selected fields in the<c>CustomActionFilterOperation</c>.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class FilterOperationSelectedFieldsConfiguration
    {
        private List<ColumnIdentifier> _selectedColumns = AWSConfigs.InitializeCollections ? new List<ColumnIdentifier>() : null;
        private SelectedFieldOptions _selectedFieldOptions;
        private List<string> _selectedFields = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SelectedColumns. 
        /// <para>
        /// The selected columns of a dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<ColumnIdentifier> SelectedColumns
        {
            get { return this._selectedColumns; }
            set { this._selectedColumns = value; }
        }

        // Check to see if SelectedColumns property is set
        internal bool IsSetSelectedColumns()
        {
            return this._selectedColumns != null && (this._selectedColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SelectedFieldOptions. 
        /// <para>
        /// A structure that contains the options that choose which fields are filtered in the
        /// <c>CustomActionFilterOperation</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values are defined as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL_FIELDS</c>: Applies the filter operation to all fields.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SelectedFieldOptions SelectedFieldOptions
        {
            get { return this._selectedFieldOptions; }
            set { this._selectedFieldOptions = value; }
        }

        // Check to see if SelectedFieldOptions property is set
        internal bool IsSetSelectedFieldOptions()
        {
            return this._selectedFieldOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SelectedFields. 
        /// <para>
        /// Chooses the fields that are filtered in <c>CustomActionFilterOperation</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> SelectedFields
        {
            get { return this._selectedFields; }
            set { this._selectedFields = value; }
        }

        // Check to see if SelectedFields property is set
        internal bool IsSetSelectedFields()
        {
            return this._selectedFields != null && (this._selectedFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}