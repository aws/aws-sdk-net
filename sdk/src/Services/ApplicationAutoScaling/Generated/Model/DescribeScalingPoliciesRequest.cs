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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeScalingPolicies operation.
    /// Provides descriptive information for scaling policies with a specified service namespace.
    /// 
    ///  
    /// <para>
    /// You can filter the results in a service namespace with the <code>ResourceId</code>,
    /// <code>ScalableDimension</code>, and <code>PolicyNames</code> parameters.
    /// </para>
    ///  
    /// <para>
    /// To create a new scaling policy or update an existing one, see <a>PutScalingPolicy</a>.
    /// If you are no longer using a scaling policy, you can delete it with <a>DeleteScalingPolicy</a>.
    /// </para>
    /// </summary>
    public partial class DescribeScalingPoliciesRequest : AmazonApplicationAutoScalingRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _policyNames = new List<string>();
        private string _resourceId;
        private ScalableDimension _scalableDimension;
        private ServiceNamespace _serviceNamespace;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of scaling policy results returned by <code>DescribeScalingPolicies</code>
        /// in paginated output. When this parameter is used, <code>DescribeScalingPolicies</code>
        /// returns up to <code>MaxResults</code> results in a single page along with a <code>NextToken</code>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <code>DescribeScalingPolicies</code> request with the returned <code>NextToken</code>
        /// value. This value can be between 1 and 50. If this parameter is not used, then <code>DescribeScalingPolicies</code>
        /// returns up to 50 results and a <code>NextToken</code> value, if applicable.
        /// </para>
        /// </summary>
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
        /// The <code>NextToken</code> value returned from a previous paginated <code>DescribeScalingPolicies</code>
        /// request. Pagination continues from the end of the previous results that returned the
        /// <code>NextToken</code> value. This value is <code>null</code> when there are no more
        /// results to return.
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
        /// Gets and sets the property PolicyNames. 
        /// <para>
        /// The names of the scaling policies to describe.
        /// </para>
        /// </summary>
        public List<string> PolicyNames
        {
            get { return this._policyNames; }
            set { this._policyNames = value; }
        }

        // Check to see if PolicyNames property is set
        internal bool IsSetPolicyNames()
        {
            return this._policyNames != null && this._policyNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The unique resource identifier string of the scalable target that the scaling policy
        /// is associated with. For Amazon ECS services, this value is the resource type, followed
        /// by the cluster name and service name, such as <code>service/default/sample-webapp</code>.
        /// If you specify a scalable dimension, you must also specify a resource ID.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ScalableDimension. 
        /// <para>
        /// The scalable dimension of the scalable target that the scaling policy is associated
        /// with. The scalable dimension contains the service namespace, resource type, and scaling
        /// property, such as <code>ecs:service:DesiredCount</code> for the desired task count
        /// of an Amazon ECS service. If you specify a scalable dimension, you must also specify
        /// a resource ID.
        /// </para>
        /// </summary>
        public ScalableDimension ScalableDimension
        {
            get { return this._scalableDimension; }
            set { this._scalableDimension = value; }
        }

        // Check to see if ScalableDimension property is set
        internal bool IsSetScalableDimension()
        {
            return this._scalableDimension != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNamespace. 
        /// <para>
        /// The AWS service namespace of the scalable target that the scaling policy is associated
        /// with. For more information, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#genref-aws-service-namespaces">AWS
        /// Service Namespaces</a> in the Amazon Web Services General Reference.
        /// </para>
        /// </summary>
        public ServiceNamespace ServiceNamespace
        {
            get { return this._serviceNamespace; }
            set { this._serviceNamespace = value; }
        }

        // Check to see if ServiceNamespace property is set
        internal bool IsSetServiceNamespace()
        {
            return this._serviceNamespace != null;
        }

    }
}