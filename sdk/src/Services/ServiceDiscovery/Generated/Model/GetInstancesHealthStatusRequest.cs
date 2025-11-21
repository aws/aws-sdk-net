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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
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
namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// Container for the parameters to the GetInstancesHealthStatus operation.
    /// Gets the current health status (<c>Healthy</c>, <c>Unhealthy</c>, or <c>Unknown</c>)
    /// of one or more instances that are associated with a specified service.
    /// 
    ///  <note> 
    /// <para>
    /// There's a brief delay between when you register an instance and when the health status
    /// for the instance is available. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetInstancesHealthStatusRequest : AmazonServiceDiscoveryRequest
    {
        private List<string> _instances = AWSConfigs.InitializeCollections ? new List<string>() : null;
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
        /// If you omit <c>Instances</c>, Cloud Map returns the health status for all the instances
        /// that are associated with the specified service.
        /// </para>
        ///  <note> 
        /// <para>
        /// To get the IDs for the instances that you've registered by using a specified service,
        /// submit a <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_ListInstances.html">ListInstances</a>
        /// request.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && (this._instances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of instances that you want Cloud Map to return in the response
        /// to a <c>GetInstancesHealthStatus</c> request. If you don't specify a value for <c>MaxResults</c>,
        /// Cloud Map returns up to 100 instances.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// For the first <c>GetInstancesHealthStatus</c> request, omit this value.
        /// </para>
        ///  
        /// <para>
        /// If more than <c>MaxResults</c> instances match the specified criteria, you can submit
        /// another <c>GetInstancesHealthStatus</c> request to get the next group of results.
        /// Specify the value of <c>NextToken</c> from the previous response in the next request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
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
        /// The ID or Amazon Resource Name (ARN) of the service that the instance is associated
        /// with. For services created in a shared namespace, specify the service ARN. For more
        /// information about shared namespaces, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/sharing-namespaces.html">Cross-account
        /// Cloud Map namespace sharing</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
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