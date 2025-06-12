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
    /// Container for the parameters to the GetDiscoveredResourceCounts operation.
    /// Returns the resource types, the number of each resource type, and the total number
    /// of resources that Config is recording in this region for your Amazon Web Services
    /// account. 
    /// 
    ///  
    /// <para>
    ///  <b>Example</b> 
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Config is recording three resource types in the US East (Ohio) Region for your account:
    /// 25 EC2 instances, 20 IAM users, and 15 S3 buckets.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You make a call to the <c>GetDiscoveredResourceCounts</c> action and specify that
    /// you want all resource types. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Config returns the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The resource types (EC2 instances, IAM users, and S3 buckets).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The number of each resource type (25, 20, and 15).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The total number of all resources (60).
    /// </para>
    ///  </li> </ul> </li> </ol> 
    /// <para>
    /// The response is paginated. By default, Config lists 100 <a>ResourceCount</a> objects
    /// on each page. You can customize this number with the <c>limit</c> parameter. The response
    /// includes a <c>nextToken</c> string. To get the next page of results, run the request
    /// again and specify the string for the <c>nextToken</c> parameter.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you make a call to the <a>GetDiscoveredResourceCounts</a> action, you might not
    /// immediately receive resource counts in the following situations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You are a new Config customer.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You just enabled resource recording.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// It might take a few minutes for Config to record and count your resources. Wait a
    /// few minutes and then retry the <a>GetDiscoveredResourceCounts</a> action. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetDiscoveredResourceCountsRequest : AmazonConfigServiceRequest
    {
        private int? _limit;
        private string _nextToken;
        private List<string> _resourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of <a>ResourceCount</a> objects returned on each page. The default
        /// is 100. You cannot specify a number greater than 100. If you specify 0, Config uses
        /// the default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> string returned on a previous page that you use to get the next
        /// page of results in a paginated response.
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
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// The comma-separated list that specifies the resource types that you want Config to
        /// return (for example, <c>"AWS::EC2::Instance"</c>, <c>"AWS::IAM::User"</c>).
        /// </para>
        ///  
        /// <para>
        /// If a value for <c>resourceTypes</c> is not specified, Config returns all resource
        /// types that Config is recording in the region for your account.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the configuration recorder is turned off, Config returns an empty list of <a>ResourceCount</a>
        /// objects. If the configuration recorder is not recording a specific resource type (for
        /// example, S3 buckets), that resource type is not returned in the list of <a>ResourceCount</a>
        /// objects.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && (this._resourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}