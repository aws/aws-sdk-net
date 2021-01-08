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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the ListTrafficPolicyInstancesByPolicy operation.
    /// Gets information about the traffic policy instances that you created by using a specify
    /// traffic policy version.
    /// 
    ///  <note> 
    /// <para>
    /// After you submit a <code>CreateTrafficPolicyInstance</code> or an <code>UpdateTrafficPolicyInstance</code>
    /// request, there's a brief delay while Amazon Route 53 creates the resource record sets
    /// that are specified in the traffic policy definition. For more information, see the
    /// <code>State</code> response element.
    /// </para>
    ///  </note> 
    /// <para>
    /// Route 53 returns a maximum of 100 items in each response. If you have a lot of traffic
    /// policy instances, you can use the <code>MaxItems</code> parameter to list them in
    /// groups of up to 100.
    /// </para>
    /// </summary>
    public partial class ListTrafficPolicyInstancesByPolicyRequest : AmazonRoute53Request
    {
        private string _trafficPolicyId;
        private int? _trafficPolicyVersion;
        private string _hostedZoneIdMarker;
        private string _trafficPolicyInstanceNameMarker;
        private RRType _trafficPolicyInstanceTypeMarker;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property TrafficPolicyId. 
        /// <para>
        /// The ID of the traffic policy for which you want to list traffic policy instances.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string TrafficPolicyId
        {
            get { return this._trafficPolicyId; }
            set { this._trafficPolicyId = value; }
        }

        // Check to see if TrafficPolicyId property is set
        internal bool IsSetTrafficPolicyId()
        {
            return this._trafficPolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyVersion. 
        /// <para>
        /// The version of the traffic policy for which you want to list traffic policy instances.
        /// The version must be associated with the traffic policy that is specified by <code>TrafficPolicyId</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public int TrafficPolicyVersion
        {
            get { return this._trafficPolicyVersion.GetValueOrDefault(); }
            set { this._trafficPolicyVersion = value; }
        }

        // Check to see if TrafficPolicyVersion property is set
        internal bool IsSetTrafficPolicyVersion()
        {
            return this._trafficPolicyVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HostedZoneIdMarker. 
        /// <para>
        /// If the value of <code>IsTruncated</code> in the previous response was <code>true</code>,
        /// you have more traffic policy instances. To get more traffic policy instances, submit
        /// another <code>ListTrafficPolicyInstancesByPolicy</code> request. 
        /// </para>
        ///  
        /// <para>
        /// For the value of <code>hostedzoneid</code>, specify the value of <code>HostedZoneIdMarker</code>
        /// from the previous response, which is the hosted zone ID of the first traffic policy
        /// instance that Amazon Route 53 will return if you submit another request.
        /// </para>
        ///  
        /// <para>
        /// If the value of <code>IsTruncated</code> in the previous response was <code>false</code>,
        /// there are no more traffic policy instances to get.
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
        /// If the value of <code>IsTruncated</code> in the previous response was <code>true</code>,
        /// you have more traffic policy instances. To get more traffic policy instances, submit
        /// another <code>ListTrafficPolicyInstancesByPolicy</code> request.
        /// </para>
        ///  
        /// <para>
        /// For the value of <code>trafficpolicyinstancename</code>, specify the value of <code>TrafficPolicyInstanceNameMarker</code>
        /// from the previous response, which is the name of the first traffic policy instance
        /// that Amazon Route 53 will return if you submit another request.
        /// </para>
        ///  
        /// <para>
        /// If the value of <code>IsTruncated</code> in the previous response was <code>false</code>,
        /// there are no more traffic policy instances to get.
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
        /// If the value of <code>IsTruncated</code> in the previous response was <code>true</code>,
        /// you have more traffic policy instances. To get more traffic policy instances, submit
        /// another <code>ListTrafficPolicyInstancesByPolicy</code> request.
        /// </para>
        ///  
        /// <para>
        /// For the value of <code>trafficpolicyinstancetype</code>, specify the value of <code>TrafficPolicyInstanceTypeMarker</code>
        /// from the previous response, which is the name of the first traffic policy instance
        /// that Amazon Route 53 will return if you submit another request.
        /// </para>
        ///  
        /// <para>
        /// If the value of <code>IsTruncated</code> in the previous response was <code>false</code>,
        /// there are no more traffic policy instances to get.
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
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of traffic policy instances to be included in the response body
        /// for this request. If you have more than <code>MaxItems</code> traffic policy instances,
        /// the value of the <code>IsTruncated</code> element in the response is <code>true</code>,
        /// and the values of <code>HostedZoneIdMarker</code>, <code>TrafficPolicyInstanceNameMarker</code>,
        /// and <code>TrafficPolicyInstanceTypeMarker</code> represent the first traffic policy
        /// instance that Amazon Route 53 will return if you submit another request.
        /// </para>
        /// </summary>
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