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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This is the response object from the GetDiscoveredResourceCounts operation.
    /// </summary>
    public partial class GetDiscoveredResourceCountsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ResourceCount> _resourceCounts = new List<ResourceCount>();
        private long? _totalDiscoveredResources;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The string that you use in a subsequent request to get the next page of results in
        /// a paginated response.
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
        /// Gets and sets the property ResourceCounts. 
        /// <para>
        /// The list of <code>ResourceCount</code> objects. Each object is listed in descending
        /// order by the number of resources.
        /// </para>
        /// </summary>
        public List<ResourceCount> ResourceCounts
        {
            get { return this._resourceCounts; }
            set { this._resourceCounts = value; }
        }

        // Check to see if ResourceCounts property is set
        internal bool IsSetResourceCounts()
        {
            return this._resourceCounts != null && this._resourceCounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TotalDiscoveredResources. 
        /// <para>
        /// The total number of resources that AWS Config is recording in the region for your
        /// account. If you specify resource types in the request, AWS Config returns only the
        /// total number of resources for those resource types.
        /// </para>
        ///  <p class="title"> <b>Example</b> 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// AWS Config is recording three resource types in the US East (Ohio) Region for your
        /// account: 25 EC2 instances, 20 IAM users, and 15 S3 buckets, for a total of 60 resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You make a call to the <code>GetDiscoveredResourceCounts</code> action and specify
        /// the resource type, <code>"AWS::EC2::Instances"</code>, in the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Config returns 25 for <code>totalDiscoveredResources</code>.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        public long TotalDiscoveredResources
        {
            get { return this._totalDiscoveredResources.GetValueOrDefault(); }
            set { this._totalDiscoveredResources = value; }
        }

        // Check to see if TotalDiscoveredResources property is set
        internal bool IsSetTotalDiscoveredResources()
        {
            return this._totalDiscoveredResources.HasValue; 
        }

    }
}