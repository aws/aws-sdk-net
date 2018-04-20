/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about the delete operation.
    /// </summary>
    public partial class InventoryDeletionSummary
    {
        private int? _remainingCount;
        private List<InventoryDeletionSummaryItem> _summaryItems = new List<InventoryDeletionSummaryItem>();
        private int? _totalCount;

        /// <summary>
        /// Gets and sets the property RemainingCount. 
        /// <para>
        /// Remaining number of items to delete.
        /// </para>
        /// </summary>
        public int RemainingCount
        {
            get { return this._remainingCount.GetValueOrDefault(); }
            set { this._remainingCount = value; }
        }

        // Check to see if RemainingCount property is set
        internal bool IsSetRemainingCount()
        {
            return this._remainingCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SummaryItems. 
        /// <para>
        /// A list of counts and versions for deleted items.
        /// </para>
        /// </summary>
        public List<InventoryDeletionSummaryItem> SummaryItems
        {
            get { return this._summaryItems; }
            set { this._summaryItems = value; }
        }

        // Check to see if SummaryItems property is set
        internal bool IsSetSummaryItems()
        {
            return this._summaryItems != null && this._summaryItems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of items to delete. This count does not change during the delete
        /// operation.
        /// </para>
        /// </summary>
        public int TotalCount
        {
            get { return this._totalCount.GetValueOrDefault(); }
            set { this._totalCount = value; }
        }

        // Check to see if TotalCount property is set
        internal bool IsSetTotalCount()
        {
            return this._totalCount.HasValue; 
        }

    }
}