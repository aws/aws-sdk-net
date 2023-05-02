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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Container for the parameters to the ListDiscoveryJobs operation.
    /// Provides a list of the existing discovery jobs in the Amazon Web Services Region and
    /// Amazon Web Services account where you're using DataSync Discovery.
    /// </summary>
    public partial class ListDiscoveryJobsRequest : AmazonDataSyncRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _storageSystemArn;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies how many results you want in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// Specifies an opaque string that indicates the position to begin the next list of results
        /// in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Max=65535)]
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
        /// Gets and sets the property StorageSystemArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of an on-premises storage system. Use this
        /// parameter if you only want to list the discovery jobs that are associated with a specific
        /// storage system.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string StorageSystemArn
        {
            get { return this._storageSystemArn; }
            set { this._storageSystemArn = value; }
        }

        // Check to see if StorageSystemArn property is set
        internal bool IsSetStorageSystemArn()
        {
            return this._storageSystemArn != null;
        }

    }
}