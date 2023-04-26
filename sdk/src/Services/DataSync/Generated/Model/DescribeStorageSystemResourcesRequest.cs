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
    /// Container for the parameters to the DescribeStorageSystemResources operation.
    /// Returns information that DataSync Discovery collects about resources in your on-premises
    /// storage system.
    /// </summary>
    public partial class DescribeStorageSystemResourcesRequest : AmazonDataSyncRequest
    {
        private string _discoveryJobArn;
        private Dictionary<string, List<string>> _filter = new Dictionary<string, List<string>>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _resourceIds = new List<string>();
        private DiscoveryResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property DiscoveryJobArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the discovery job that's collecting data
        /// from your on-premises storage system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string DiscoveryJobArn
        {
            get { return this._discoveryJobArn; }
            set { this._discoveryJobArn = value; }
        }

        // Check to see if DiscoveryJobArn property is set
        internal bool IsSetDiscoveryJobArn()
        {
            return this._discoveryJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Filters the storage system resources that you want returned. For example, this might
        /// be volumes associated with a specific storage virtual machine (SVM).
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null && this._filter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of storage system resources that you want to list in
        /// a response.
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
        /// Gets and sets the property ResourceIds. 
        /// <para>
        /// Specifies the universally unique identifiers (UUIDs) of the storage system resources
        /// that you want information about. You can't use this parameter in combination with
        /// the <code>Filter</code> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> ResourceIds
        {
            get { return this._resourceIds; }
            set { this._resourceIds = value; }
        }

        // Check to see if ResourceIds property is set
        internal bool IsSetResourceIds()
        {
            return this._resourceIds != null && this._resourceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specifies what kind of storage system resources that you want information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DiscoveryResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}