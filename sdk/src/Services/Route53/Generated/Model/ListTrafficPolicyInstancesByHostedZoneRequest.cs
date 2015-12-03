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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the ListTrafficPolicyInstancesByHostedZone operation.
    /// Gets information about the traffic policy instances that you created in a specified
    /// hosted zone.
    /// 
    ///  <note>After you submit an <code>UpdateTrafficPolicyInstance</code> request, there's
    /// a brief delay while Amazon Route 53 creates the resource record sets that are specified
    /// in the traffic policy definition. For more information, see the <a>State</a> response
    /// element.</note> 
    /// <para>
    /// To get information about the traffic policy instances that you created in a specified
    /// hosted zone, send a <code>GET</code> request to the <code>2013-04-01/trafficpolicyinstance</code>
    /// resource and include the ID of the hosted zone.
    /// </para>
    ///  
    /// <para>
    /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
    /// of traffic policy instances, you can use the <code>MaxItems</code> parameter to list
    /// them in groups of up to 100.
    /// </para>
    ///  
    /// <para>
    /// The response includes four values that help you navigate from one group of <code>MaxItems</code>
    /// traffic policy instances to the next:
    /// </para>
    ///  <ul> <li><b>IsTruncated</b></li> 
    /// <para>
    /// If the value of <code/>IsTruncated in the response is <code>true</code>, there are
    /// more traffic policy instances associated with the current AWS account.
    /// </para>
    ///  
    /// <para>
    /// If <code>IsTruncated</code> is <code>false</code>, this response includes the last
    /// traffic policy instance that is associated with the current account.
    /// </para>
    ///  <li><b>MaxItems</b></li> 
    /// <para>
    /// The value that you specified for the <code>MaxItems</code> parameter in the request
    /// that produced the current response.
    /// </para>
    ///  <li><b>TrafficPolicyInstanceNameMarker</b> and <b>TrafficPolicyInstanceTypeMarker</b></li>
    /// 
    /// <para>
    /// If <code>IsTruncated</code> is <code>true</code>, these two values in the response
    /// represent the first traffic policy instance in the next group of <code>MaxItems</code>
    /// traffic policy instances. To list more traffic policy instances, make another call
    /// to <code>ListTrafficPolicyInstancesByHostedZone</code>, and specify these values in
    /// the corresponding request parameters.
    /// </para>
    ///  
    /// <para>
    /// If <code>IsTruncated</code> is <code>false</code>, all three elements are omitted
    /// from the response.
    /// </para>
    ///  </ul>
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
        /// The ID of the hosted zone for which you want to list traffic policy instances.
        /// </para>
        /// </summary>
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
        /// For the first request to <code>ListTrafficPolicyInstancesByHostedZone</code>, omit
        /// this value.
        /// </para>
        ///  
        /// <para>
        /// If the value of <code>IsTruncated</code> in the previous response was <code>true</code>,
        /// <code>TrafficPolicyInstanceNameMarker</code> is the name of the first traffic policy
        /// instance in the next group of <code>MaxItems</code> traffic policy instances.
        /// </para>
        ///  
        /// <para>
        /// If the value of <code>IsTruncated</code> in the previous response was <code>false</code>,
        /// there are no more traffic policy instances to get for this hosted zone.
        /// </para>
        ///  
        /// <para>
        /// If the value of <code>IsTruncated</code> in the previous response was <code>false</code>,
        /// omit this value.
        /// </para>
        /// </summary>
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
        /// For the first request to <code>ListTrafficPolicyInstancesByHostedZone</code>, omit
        /// this value.
        /// </para>
        ///  
        /// <para>
        /// If the value of <code>IsTruncated</code> in the previous response was <code>true</code>,
        /// <code>TrafficPolicyInstanceTypeMarker</code> is the DNS type of the first traffic
        /// policy instance in the next group of <code>MaxItems</code> traffic policy instances.
        /// </para>
        ///  
        /// <para>
        /// If the value of <code>IsTruncated</code> in the previous response was <code>false</code>,
        /// there are no more traffic policy instances to get for this hosted zone.
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
        /// instance in the next group of <code>MaxItems</code> traffic policy instances.
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