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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
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
namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDeleteImportData operation.
    /// Deletes one or more import tasks, each identified by their import ID. Each import
    /// task has a number of records that can identify servers or applications. 
    /// 
    ///  
    /// <para>
    /// Amazon Web Services Application Discovery Service has built-in matching logic that
    /// will identify when discovered servers match existing entries that you've previously
    /// discovered, the information for the already-existing discovered server is updated.
    /// When you delete an import task that contains records that were used to match, the
    /// information in those matched records that comes from the deleted records will also
    /// be deleted.
    /// </para>
    /// </summary>
    public partial class BatchDeleteImportDataRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private bool? _deleteHistory;
        private List<string> _importTaskIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DeleteHistory. 
        /// <para>
        ///  Set to <c>true</c> to remove the deleted import task from <a>DescribeImportTasks</a>.
        /// 
        /// </para>
        /// </summary>
        public bool? DeleteHistory
        {
            get { return this._deleteHistory; }
            set { this._deleteHistory = value; }
        }

        // Check to see if DeleteHistory property is set
        internal bool IsSetDeleteHistory()
        {
            return this._deleteHistory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportTaskIds. 
        /// <para>
        /// The IDs for the import tasks that you want to delete.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> ImportTaskIds
        {
            get { return this._importTaskIds; }
            set { this._importTaskIds = value; }
        }

        // Check to see if ImportTaskIds property is set
        internal bool IsSetImportTaskIds()
        {
            return this._importTaskIds != null && (this._importTaskIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}