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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeInstanceCreditSpecifications operation.
    /// Describes the credit option for CPU usage of the specified burstable performance instances.
    /// The credit options are <code>standard</code> and <code>unlimited</code>.
    /// 
    ///  
    /// <para>
    /// If you do not specify an instance ID, Amazon EC2 returns burstable performance instances
    /// with the <code>unlimited</code> credit option, as well as instances that were previously
    /// configured as T2, T3, and T3a with the <code>unlimited</code> credit option. For example,
    /// if you resize a T2 instance, while it is configured as <code>unlimited</code>, to
    /// an M4 instance, Amazon EC2 returns the M4 instance.
    /// </para>
    ///  
    /// <para>
    /// If you specify one or more instance IDs, Amazon EC2 returns the credit option (<code>standard</code>
    /// or <code>unlimited</code>) of those instances. If you specify an instance ID that
    /// is not valid, such as an instance that is not a burstable performance instance, an
    /// error is returned.
    /// </para>
    ///  
    /// <para>
    /// Recently terminated instances might appear in the returned results. This interval
    /// is usually less than one hour.
    /// </para>
    ///  
    /// <para>
    /// If an Availability Zone is experiencing a service disruption and you specify instance
    /// IDs in the affected zone, or do not specify any instance IDs at all, the call fails.
    /// If you specify only instance IDs in an unaffected zone, the call works normally.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html">Burstable
    /// performance instances</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeInstanceCreditSpecificationsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _instanceIds = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>instance-id</code> - The ID of the instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The instance IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your instances.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum 1000 explicitly specified instance IDs.
        /// </para>
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && this._instanceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. This value can be between
        /// 5 and 1000. You cannot specify this parameter and the instance IDs parameter in the
        /// same call. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
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
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
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

    }
}