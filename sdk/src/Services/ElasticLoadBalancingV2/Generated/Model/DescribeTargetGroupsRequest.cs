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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTargetGroups operation.
    /// Describes the specified target groups or all of your target groups. By default, all
    /// target groups are described. Alternatively, you can specify one of the following to
    /// filter the results: the ARN of the load balancer, the names of one or more target
    /// groups, or the ARNs of one or more target groups.
    /// 
    ///  
    /// <para>
    /// To describe the targets for a target group, use <a>DescribeTargetHealth</a>. To describe
    /// the attributes of a target group, use <a>DescribeTargetGroupAttributes</a>.
    /// </para>
    /// </summary>
    public partial class DescribeTargetGroupsRequest : AmazonElasticLoadBalancingV2Request
    {
        private string _loadBalancerArn;
        private string _marker;
        private List<string> _names = new List<string>();
        private int? _pageSize;
        private List<string> _targetGroupArns = new List<string>();

        /// <summary>
        /// Gets and sets the property LoadBalancerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the load balancer.
        /// </para>
        /// </summary>
        public string LoadBalancerArn
        {
            get { return this._loadBalancerArn; }
            set { this._loadBalancerArn = value; }
        }

        // Check to see if LoadBalancerArn property is set
        internal bool IsSetLoadBalancerArn()
        {
            return this._loadBalancerArn != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The marker for the next set of results. (You received this marker from a previous
        /// call.)
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        /// The names of the target groups.
        /// </para>
        /// </summary>
        public List<string> Names
        {
            get { return this._names; }
            set { this._names = value; }
        }

        // Check to see if Names property is set
        internal bool IsSetNames()
        {
            return this._names != null && this._names.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The maximum number of results to return with this call.
        /// </para>
        /// </summary>
        public int PageSize
        {
            get { return this._pageSize.GetValueOrDefault(); }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetGroupArns. 
        /// <para>
        /// The Amazon Resource Names (ARN) of the target groups.
        /// </para>
        /// </summary>
        public List<string> TargetGroupArns
        {
            get { return this._targetGroupArns; }
            set { this._targetGroupArns = value; }
        }

        // Check to see if TargetGroupArns property is set
        internal bool IsSetTargetGroupArns()
        {
            return this._targetGroupArns != null && this._targetGroupArns.Count > 0; 
        }

    }
}