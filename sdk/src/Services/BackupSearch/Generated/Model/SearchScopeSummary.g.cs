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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The summary of the specified search job scope, including: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// TotalBackupsToScanCount, the number of recovery points returned by the search.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// TotalItemsToScanCount, the number of items returned by the search.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class SearchScopeSummary
    {
        /// <summary>
        /// Gets and sets the property TotalItemsToScanCount. 
        /// <para>
        /// This is the count of the total number of items that will be scanned in a search.
        /// </para>
        /// </summary>
        public long? TotalItemsToScanCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalItemsToScanCount property is set.
        /// </summary>
        internal bool IsSetTotalItemsToScanCount() => this.TotalItemsToScanCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalRecoveryPointsToScanCount. 
        /// <para>
        /// This is the count of the total number of backups that will be scanned in a search.
        /// </para>
        /// </summary>
        public int? TotalRecoveryPointsToScanCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalRecoveryPointsToScanCount property is set.
        /// </summary>
        internal bool IsSetTotalRecoveryPointsToScanCount() => this.TotalRecoveryPointsToScanCount.HasValue;
    }
}
