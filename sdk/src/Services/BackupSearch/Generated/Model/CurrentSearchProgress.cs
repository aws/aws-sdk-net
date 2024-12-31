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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
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
namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// This contains information results retrieved from a search job that may not have completed.
    /// </summary>
    public partial class CurrentSearchProgress
    {
        private long? _itemsMatchedCount;
        private long? _itemsScannedCount;
        private int? _recoveryPointsScannedCount;

        /// <summary>
        /// Gets and sets the property ItemsMatchedCount. 
        /// <para>
        /// This number is the sum of all items that match the item filters in a search job in
        /// progress.
        /// </para>
        /// </summary>
        public long ItemsMatchedCount
        {
            get { return this._itemsMatchedCount.GetValueOrDefault(); }
            set { this._itemsMatchedCount = value; }
        }

        // Check to see if ItemsMatchedCount property is set
        internal bool IsSetItemsMatchedCount()
        {
            return this._itemsMatchedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ItemsScannedCount. 
        /// <para>
        /// This number is the sum of all items that have been scanned so far during a search
        /// job.
        /// </para>
        /// </summary>
        public long ItemsScannedCount
        {
            get { return this._itemsScannedCount.GetValueOrDefault(); }
            set { this._itemsScannedCount = value; }
        }

        // Check to see if ItemsScannedCount property is set
        internal bool IsSetItemsScannedCount()
        {
            return this._itemsScannedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecoveryPointsScannedCount. 
        /// <para>
        /// This number is the sum of all backups that have been scanned so far during a search
        /// job.
        /// </para>
        /// </summary>
        public int RecoveryPointsScannedCount
        {
            get { return this._recoveryPointsScannedCount.GetValueOrDefault(); }
            set { this._recoveryPointsScannedCount = value; }
        }

        // Check to see if RecoveryPointsScannedCount property is set
        internal bool IsSetRecoveryPointsScannedCount()
        {
            return this._recoveryPointsScannedCount.HasValue; 
        }

    }
}