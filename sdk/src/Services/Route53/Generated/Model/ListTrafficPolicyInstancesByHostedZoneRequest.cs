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
    /// Container for the parameters to the ListTrafficPolicyInstancesByHostedZone operation.
    /// Gets information about the traffic policy instances that you created in a specified
    /// hosted zone.
    /// 
    ///  <note> 
    /// <para>
    /// After you submit a <c>CreateTrafficPolicyInstance</c> or an <c>UpdateTrafficPolicyInstance</c>
    /// request, there's a brief delay while Amazon Route 53 creates the resource record sets
    /// that are specified in the traffic policy definition. For more information, see the
    /// <c>State</c> response element.
    /// </para>
    ///  </note> 
    /// <para>
    /// Route 53 returns a maximum of 100 items in each response. If you have a lot of traffic
    /// policy instances, you can use the <c>MaxItems</c> parameter to list them in groups
    /// of up to 100.
    /// </para>
    /// </summary>
    public partial class ListTrafficPolicyInstancesByHostedZoneRequest : AmazonRoute53Request
    {
        private string _hostedZoneId;
        private string _trafficPolicyInstanceNameMarker;
        private RRType _trafficPolicyInstanceTypeMarker;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone that you want to list traffic policy instances for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=32)]
        public string HostedZoneId
        {
            get { return this._hostedZoneId; }
            set { this._hostedZoneId = value; }
        }

        // Check to see if HostedZoneId property is set
        internal bool IsSetHostedZoneId()
        {
            return this._hostedZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyInstanceNameMarker. 
        /// <para>
        /// If the value of <c>IsTruncated</c> in the previous response is true, you have more
        /// traffic policy instances. To get more traffic policy instances, submit another <c>ListTrafficPolicyInstances</c>
        /// request. For the value of <c>trafficpolicyinstancename</c>, specify the value of <c>TrafficPolicyInstanceNameMarker</c>
        /// from the previous response, which is the name of the first traffic policy instance
        /// in the next group of traffic policy instances.
        /// </para>
        ///  
        /// <para>
        /// If the value of <c>IsTruncated</c> in the previous response was <c>false</c>, there
        /// are no more traffic policy instances to get.
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
        /// If the value of <c>IsTruncated</c> in the previous response is true, you have more
        /// traffic policy instances. To get more traffic policy instances, submit another <c>ListTrafficPolicyInstances</c>
        /// request. For the value of <c>trafficpolicyinstancetype</c>, specify the value of <c>TrafficPolicyInstanceTypeMarker</c>
        /// from the previous response, which is the type of the first traffic policy instance
        /// in the next group of traffic policy instances.
        /// </para>
        ///  
        /// <para>
        /// If the value of <c>IsTruncated</c> in the previous response was <c>false</c>, there
        /// are no more traffic policy instances to get.
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
        /// for this request. If you have more than <c>MaxItems</c> traffic policy instances,
        /// the value of the <c>IsTruncated</c> element in the response is <c>true</c>, and the
        /// values of <c>HostedZoneIdMarker</c>, <c>TrafficPolicyInstanceNameMarker</c>, and <c>TrafficPolicyInstanceTypeMarker</c>
        /// represent the first traffic policy instance that Amazon Route 53 will return if you
        /// submit another request.
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