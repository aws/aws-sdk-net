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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ListResourceDataSync operation.
    /// Lists your resource data sync configurations. Includes information about the last
    /// time a sync attempted to start, the last sync status, and the last time a sync successfully
    /// completed.
    /// 
    ///  
    /// <para>
    /// The number of sync configurations might be too large to return using a single call
    /// to <c>ListResourceDataSync</c>. You can limit the number of sync configurations returned
    /// by using the <c>MaxResults</c> parameter. To determine whether there are more sync
    /// configurations to list, check the value of <c>NextToken</c> in the output. If there
    /// are more sync configurations to list, you can request them by specifying the <c>NextToken</c>
    /// returned in the call to the parameter of a subsequent call. 
    /// </para>
    /// </summary>
    public partial class ListResourceDataSyncRequest : AmazonSimpleSystemsManagementRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _syncType;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to start the list. Use this token to get the next set of results. 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SyncType. 
        /// <para>
        /// View a list of resource data syncs according to the sync type. Specify <c>SyncToDestination</c>
        /// to view resource data syncs that synchronize data to an Amazon S3 bucket. Specify
        /// <c>SyncFromSource</c> to view resource data syncs from Organizations or from multiple
        /// Amazon Web Services Regions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string SyncType
        {
            get { return this._syncType; }
            set { this._syncType = value; }
        }

        // Check to see if SyncType property is set
        internal bool IsSetSyncType()
        {
            return this._syncType != null;
        }

    }
}