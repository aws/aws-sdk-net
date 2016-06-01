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
    /// Container for the parameters to the DescribeScalableTargets operation.
    /// Provides descriptive information for scalable targets with a specified service namespace.
    /// 
    ///  
    /// <para>
    /// You can filter the results in a service namespace with the <code>ResourceIds</code>
    /// and <code>ScalableDimension</code> parameters.
    /// </para>
    ///  
    /// <para>
    /// To create a new scalable target or update an existing one, see <a>RegisterScalableTarget</a>.
    /// If you are no longer using a scalable target, you can deregister it with <a>DeregisterScalableTarget</a>.
    /// </para>
    /// </summary>
    public partial class DescribeScalableTargetsRequest : AmazonApplicationAutoScalingRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _resourceIds = new List<string>();
        private ScalableDimension _scalableDimension;
        private ServiceNamespace _serviceNamespace;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of scalable target results returned by <code>DescribeScalableTargets</code>
        /// in paginated output. When this parameter is used, <code>DescribeScalableTargets</code>
        /// returns up to <code>MaxResults</code> results in a single page along with a <code>NextToken</code>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <code>DescribeScalableTargets</code> request with the returned <code>NextToken</code>
        /// value. This value can be between 1 and 50. If this parameter is not used, then <code>DescribeScalableTargets</code>
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
        /// The <code>NextToken</code> value returned from a previous paginated <code>DescribeScalableTargets</code>
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
        /// Gets and sets the property ResourceIds. 
        /// <para>
        /// The unique identifier string for the resource associated with the scalable target.
        /// For Amazon ECS services, this value is the resource type, followed by the cluster
        /// name, and then the service name, such as <code>service/default/sample-webapp</code>.
        /// If you specify a scalable dimension, you must also specify a resource ID.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ScalableDimension. 
        /// <para>
        /// The scalable dimension associated with the scalable target. The scalable dimension
        /// contains the service namespace, the resource type, and the scaling property, such
        /// as <code>ecs:service:DesiredCount</code> for the desired task count for an Amazon
        /// ECS service. If you specify a scalable dimension, you must also specify a resource
        /// ID.
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
        /// The namespace for the AWS service that the scalable target is associated with. For
        /// more information, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#genref-aws-service-namespaces">AWS
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