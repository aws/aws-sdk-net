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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This is the response object from the GetDiscoveredResourceCounts operation.
    /// </summary>
    public partial class GetDiscoveredResourceCountsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ResourceCount> _resourceCounts = AWSConfigs.InitializeCollections ? new List<ResourceCount>() : null;
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
        /// The list of <c>ResourceCount</c> objects. Each object is listed in descending order
        /// by the number of resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceCount> ResourceCounts
        {
            get { return this._resourceCounts; }
            set { this._resourceCounts = value; }
        }

        // Check to see if ResourceCounts property is set
        internal bool IsSetResourceCounts()
        {
            return this._resourceCounts != null && (this._resourceCounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalDiscoveredResources. 
        /// <para>
        /// The total number of resources that Config is recording in the region for your account.
        /// If you specify resource types in the request, Config returns only the total number
        /// of resources for those resource types.
        /// </para>
        ///  
        /// <para>
        ///  <b>Example</b> 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Config is recording three resource types in the US East (Ohio) Region for your account:
        /// 25 EC2 instances, 20 IAM users, and 15 S3 buckets, for a total of 60 resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You make a call to the <c>GetDiscoveredResourceCounts</c> action and specify the resource
        /// type, <c>"AWS::EC2::Instances"</c>, in the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Config returns 25 for <c>totalDiscoveredResources</c>.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        public long? TotalDiscoveredResources
        {
            get { return this._totalDiscoveredResources; }
            set { this._totalDiscoveredResources = value; }
        }

        // Check to see if TotalDiscoveredResources property is set
        internal bool IsSetTotalDiscoveredResources()
        {
            return this._totalDiscoveredResources.HasValue; 
        }

    }
}