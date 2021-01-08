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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeInstanceRefreshes operation.
    /// Describes one or more instance refreshes.
    /// 
    ///  
    /// <para>
    /// You can determine the status of a request by looking at the <code>Status</code> parameter.
    /// The following are the possible statuses: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Pending</code> - The request was created, but the operation has not started.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>InProgress</code> - The operation is in progress.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Successful</code> - The operation completed successfully.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Failed</code> - The operation failed to complete. You can troubleshoot using
    /// the status reason and the scaling activities. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Cancelling</code> - An ongoing operation is being cancelled. Cancellation does
    /// not roll back any replacements that have already been completed, but it prevents new
    /// replacements from being started. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Cancelled</code> - The operation is cancelled. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh.html">Replacing
    /// Auto Scaling Instances Based on an Instance Refresh</a>.
    /// </para>
    /// </summary>
    public partial class DescribeInstanceRefreshesRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _instanceRefreshIds = new List<string>();
        private int? _maxRecords;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceRefreshIds. 
        /// <para>
        /// One or more instance refresh IDs.
        /// </para>
        /// </summary>
        public List<string> InstanceRefreshIds
        {
            get { return this._instanceRefreshIds; }
            set { this._instanceRefreshIds = value; }
        }

        // Check to see if InstanceRefreshIds property is set
        internal bool IsSetInstanceRefreshIds()
        {
            return this._instanceRefreshIds != null && this._instanceRefreshIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of items to return with this call. The default value is <code>50</code>
        /// and the maximum value is <code>100</code>.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
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