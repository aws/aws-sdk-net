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
    /// Container for the parameters to the DescribeTrafficSources operation.
    /// Gets information about the traffic sources for the specified Auto Scaling group.
    /// 
    ///  
    /// <para>
    /// You can optionally provide a traffic source type. If you provide a traffic source
    /// type, then the results only include that traffic source type.
    /// </para>
    ///  
    /// <para>
    /// If you do not provide a traffic source type, then the results include all the traffic
    /// sources for the specified Auto Scaling group. 
    /// </para>
    /// </summary>
    public partial class DescribeTrafficSourcesRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private int? _maxRecords;
        private string _nextToken;
        private string _trafficSourceType;

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
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of items to return with this call. The maximum value is <code>50</code>.
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

        /// <summary>
        /// Gets and sets the property TrafficSourceType. 
        /// <para>
        /// The traffic source type that you want to describe.
        /// </para>
        ///  
        /// <para>
        /// The following lists the valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>elb</code> if the traffic source is a Classic Load Balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>elbv2</code> if the traffic source is a Application Load Balancer, Gateway
        /// Load Balancer, or Network Load Balancer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-lattice</code> if the traffic source is VPC Lattice.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TrafficSourceType
        {
            get { return this._trafficSourceType; }
            set { this._trafficSourceType = value; }
        }

        // Check to see if TrafficSourceType property is set
        internal bool IsSetTrafficSourceType()
        {
            return this._trafficSourceType != null;
        }

    }
}