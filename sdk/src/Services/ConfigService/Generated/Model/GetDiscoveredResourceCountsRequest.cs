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
    /// Container for the parameters to the GetDiscoveredResourceCounts operation.
    /// Returns the resource types, the number of each resource type, and the total number
    /// of resources that AWS Config is recording in this region for your AWS account. 
    /// 
    ///  <p class="title"> <b>Example</b> 
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// AWS Config is recording three resource types in the US East (Ohio) Region for your
    /// account: 25 EC2 instances, 20 IAM users, and 15 S3 buckets.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You make a call to the <code>GetDiscoveredResourceCounts</code> action and specify
    /// that you want all resource types. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Config returns the following:
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
    /// The response is paginated. By default, AWS Config lists 100 <a>ResourceCount</a> objects
    /// on each page. You can customize this number with the <code>limit</code> parameter.
    /// The response includes a <code>nextToken</code> string. To get the next page of results,
    /// run the request again and specify the string for the <code>nextToken</code> parameter.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you make a call to the <a>GetDiscoveredResourceCounts</a> action, you might not
    /// immediately receive resource counts in the following situations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You are a new AWS Config customer.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You just enabled resource recording.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// It might take a few minutes for AWS Config to record and count your resources. Wait
    /// a few minutes and then retry the <a>GetDiscoveredResourceCounts</a> action. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetDiscoveredResourceCountsRequest : AmazonConfigServiceRequest
    {
        private int? _limit;
        private string _nextToken;
        private List<string> _resourceTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of <a>ResourceCount</a> objects returned on each page. The default
        /// is 100. You cannot specify a number greater than 100. If you specify 0, AWS Config
        /// uses the default.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
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
        /// The <code>nextToken</code> string returned on a previous page that you use to get
        /// the next page of results in a paginated response.
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
        /// The comma-separated list that specifies the resource types that you want AWS Config
        /// to return (for example, <code>"AWS::EC2::Instance"</code>, <code>"AWS::IAM::User"</code>).
        /// </para>
        ///  
        /// <para>
        /// If a value for <code>resourceTypes</code> is not specified, AWS Config returns all
        /// resource types that AWS Config is recording in the region for your account.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the configuration recorder is turned off, AWS Config returns an empty list of <a>ResourceCount</a>
        /// objects. If the configuration recorder is not recording a specific resource type (for
        /// example, S3 buckets), that resource type is not returned in the list of <a>ResourceCount</a>
        /// objects.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && this._resourceTypes.Count > 0; 
        }

    }
}