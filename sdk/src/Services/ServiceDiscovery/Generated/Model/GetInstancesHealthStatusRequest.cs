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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// Container for the parameters to the GetInstancesHealthStatus operation.
    /// Gets the current health status (<code>Healthy</code>, <code>Unhealthy</code>, or <code>Unknown</code>)
    /// of one or more instances that are associated with a specified service.
    /// 
    ///  <note> 
    /// <para>
    /// There is a brief delay between when you register an instance and when the health status
    /// for the instance is available. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetInstancesHealthStatusRequest : AmazonServiceDiscoveryRequest
    {
        private List<string> _instances = new List<string>();
        private int? _maxResults;
        private string _nextToken;
        private string _serviceId;

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// An array that contains the IDs of all the instances that you want to get the health
        /// status for.
        /// </para>
        ///  
        /// <para>
        /// If you omit <code>Instances</code>, Amazon Route 53 returns the health status for
        /// all the instances that are associated with the specified service.
        /// </para>
        ///  <note> 
        /// <para>
        /// To get the IDs for the instances that you've registered by using a specified service,
        /// submit a <a>ListInstances</a> request.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && this._instances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of instances that you want Route 53 to return in the response to
        /// a <code>GetInstancesHealthStatus</code> request. If you don't specify a value for
        /// <code>MaxResults</code>, Route 53 returns up to 100 instances.
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
        /// For the first <code>GetInstancesHealthStatus</code> request, omit this value.
        /// </para>
        ///  
        /// <para>
        /// If more than <code>MaxResults</code> instances match the specified criteria, you can
        /// submit another <code>GetInstancesHealthStatus</code> request to get the next group
        /// of results. Specify the value of <code>NextToken</code> from the previous response
        /// in the next request.
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
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID of the service that the instance is associated with.
        /// </para>
        /// </summary>
        public string ServiceId
        {
            get { return this._serviceId; }
            set { this._serviceId = value; }
        }

        // Check to see if ServiceId property is set
        internal bool IsSetServiceId()
        {
            return this._serviceId != null;
        }

    }
}