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
    /// A complex type that contains settings for the new traffic policy instance.
    /// </summary>
    public partial class TrafficPolicyInstance
    {
        private string _id;
        private string _hostedZoneId;
        private string _name;
        private long? _ttl;
        private string _state;
        private string _message;
        private string _trafficPolicyId;
        private int? _trafficPolicyVersion;
        private RRType _trafficPolicyType;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID that Amazon Route 53 assigned to the new traffic policy instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone that Amazon Route 53 created resource record sets in.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The DNS name, such as www.example.com, for which Amazon Route 53 responds to queries
        /// by using the resource record sets that are associated with this traffic policy instance.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property TTL. 
        /// <para>
        /// The TTL that Amazon Route 53 assigned to all of the resource record sets that it created
        /// in the specified hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public long? TTL
        {
            get { return this._ttl; }
            set { this._ttl = value; }
        }

        // Check to see if TTL property is set
        internal bool IsSetTTL()
        {
            return this._ttl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The value of <c>State</c> is one of the following values:
        /// </para>
        ///  <dl> <dt>Applied</dt> <dd> 
        /// <para>
        /// Amazon Route 53 has finished creating resource record sets, and changes have propagated
        /// to all Route 53 edge locations.
        /// </para>
        ///  </dd> <dt>Creating</dt> <dd> 
        /// <para>
        /// Route 53 is creating the resource record sets. Use <c>GetTrafficPolicyInstance</c>
        /// to confirm that the <c>CreateTrafficPolicyInstance</c> request completed successfully.
        /// </para>
        ///  </dd> <dt>Failed</dt> <dd> 
        /// <para>
        /// Route 53 wasn't able to create or update the resource record sets. When the value
        /// of <c>State</c> is <c>Failed</c>, see <c>Message</c> for an explanation of what caused
        /// the request to fail.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true)]
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// If <c>State</c> is <c>Failed</c>, an explanation of the reason for the failure. If
        /// <c>State</c> is another value, <c>Message</c> is empty.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyId. 
        /// <para>
        /// The ID of the traffic policy that Amazon Route 53 used to create resource record sets
        /// in the specified hosted zone.
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
        /// The version of the traffic policy that Amazon Route 53 used to create resource record
        /// sets in the specified hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public int? TrafficPolicyVersion
        {
            get { return this._trafficPolicyVersion; }
            set { this._trafficPolicyVersion = value; }
        }

        // Check to see if TrafficPolicyVersion property is set
        internal bool IsSetTrafficPolicyVersion()
        {
            return this._trafficPolicyVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyType. 
        /// <para>
        /// The DNS type that Amazon Route 53 assigned to all of the resource record sets that
        /// it created for this traffic policy instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RRType TrafficPolicyType
        {
            get { return this._trafficPolicyType; }
            set { this._trafficPolicyType = value; }
        }

        // Check to see if TrafficPolicyType property is set
        internal bool IsSetTrafficPolicyType()
        {
            return this._trafficPolicyType != null;
        }

    }
}