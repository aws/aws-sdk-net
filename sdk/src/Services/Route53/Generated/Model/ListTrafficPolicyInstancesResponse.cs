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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains the response information for the request.
    /// </summary>
    public partial class ListTrafficPolicyInstancesResponse : AmazonWebServiceResponse
    {
        private List<TrafficPolicyInstance> _trafficPolicyInstances = AWSConfigs.InitializeCollections ? new List<TrafficPolicyInstance>() : null;
        private string _hostedZoneIdMarker;
        private string _trafficPolicyInstanceNameMarker;
        private RRType _trafficPolicyInstanceTypeMarker;
        private bool? _isTruncated;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property TrafficPolicyInstances. 
        /// <para>
        /// A list that contains one <c>TrafficPolicyInstance</c> element for each traffic policy
        /// instance that matches the elements in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<TrafficPolicyInstance> TrafficPolicyInstances
        {
            get { return this._trafficPolicyInstances; }
            set { this._trafficPolicyInstances = value; }
        }

        // Check to see if TrafficPolicyInstances property is set
        internal bool IsSetTrafficPolicyInstances()
        {
            return this._trafficPolicyInstances != null && (this._trafficPolicyInstances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HostedZoneIdMarker. 
        /// <para>
        /// If <c>IsTruncated</c> is <c>true</c>, <c>HostedZoneIdMarker</c> is the ID of the hosted
        /// zone of the first traffic policy instance that Route 53 will return if you submit
        /// another <c>ListTrafficPolicyInstances</c> request. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=32)]
        public string HostedZoneIdMarker
        {
            get { return this._hostedZoneIdMarker; }
            set { this._hostedZoneIdMarker = value; }
        }

        // Check to see if HostedZoneIdMarker property is set
        internal bool IsSetHostedZoneIdMarker()
        {
            return this._hostedZoneIdMarker != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyInstanceNameMarker. 
        /// <para>
        /// If <c>IsTruncated</c> is <c>true</c>, <c>TrafficPolicyInstanceNameMarker</c> is the
        /// name of the first traffic policy instance that Route 53 will return if you submit
        /// another <c>ListTrafficPolicyInstances</c> request. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string TrafficPolicyInstanceNameMarker
        {
            get { return this._trafficPolicyInstanceNameMarker; }
            set { this._trafficPolicyInstanceNameMarker = value; }
        }

        // Check to see if TrafficPolicyInstanceNameMarker property is set
        internal bool IsSetTrafficPolicyInstanceNameMarker()
        {
            return this._trafficPolicyInstanceNameMarker != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyInstanceTypeMarker. 
        /// <para>
        /// If <c>IsTruncated</c> is <c>true</c>, <c>TrafficPolicyInstanceTypeMarker</c> is the
        /// DNS type of the resource record sets that are associated with the first traffic policy
        /// instance that Amazon Route 53 will return if you submit another <c>ListTrafficPolicyInstances</c>
        /// request. 
        /// </para>
        /// </summary>
        public RRType TrafficPolicyInstanceTypeMarker
        {
            get { return this._trafficPolicyInstanceTypeMarker; }
            set { this._trafficPolicyInstanceTypeMarker = value; }
        }

        // Check to see if TrafficPolicyInstanceTypeMarker property is set
        internal bool IsSetTrafficPolicyInstanceTypeMarker()
        {
            return this._trafficPolicyInstanceTypeMarker != null;
        }

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag that indicates whether there are more traffic policy instances to be listed.
        /// If the response was truncated, you can get more traffic policy instances by calling
        /// <c>ListTrafficPolicyInstances</c> again and specifying the values of the <c>HostedZoneIdMarker</c>,
        /// <c>TrafficPolicyInstanceNameMarker</c>, and <c>TrafficPolicyInstanceTypeMarker</c>
        /// in the corresponding request parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsTruncated
        {
            get { return this._isTruncated; }
            set { this._isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this._isTruncated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The value that you specified for the <c>MaxItems</c> parameter in the call to <c>ListTrafficPolicyInstances</c>
        /// that produced the current response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems != null;
        }

    }
}