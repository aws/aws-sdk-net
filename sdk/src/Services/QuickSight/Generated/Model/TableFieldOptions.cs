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
    /// The field options of a table visual.
    /// </summary>
    public partial class TableFieldOptions
    {
        private List<string> _order = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TablePinnedFieldOptions _pinnedFieldOptions;
        private List<TableFieldOption> _selectedFieldOptions = AWSConfigs.InitializeCollections ? new List<TableFieldOption>() : null;

        /// <summary>
        /// Gets and sets the property Order. 
        /// <para>
        /// The order of the field IDs that are configured as field options for a table visual.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<string> Order
        {
            get { return this._order; }
            set { this._order = value; }
        }

        // Check to see if Order property is set
        internal bool IsSetOrder()
        {
            return this._order != null && (this._order.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PinnedFieldOptions. 
        /// <para>
        /// The settings for the pinned columns of a table visual.
        /// </para>
        /// </summary>
        public TablePinnedFieldOptions PinnedFieldOptions
        {
            get { return this._pinnedFieldOptions; }
            set { this._pinnedFieldOptions = value; }
        }

        // Check to see if PinnedFieldOptions property is set
        internal bool IsSetPinnedFieldOptions()
        {
            return this._pinnedFieldOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SelectedFieldOptions. 
        /// <para>
        /// The field options to be configured to a table.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<TableFieldOption> SelectedFieldOptions
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