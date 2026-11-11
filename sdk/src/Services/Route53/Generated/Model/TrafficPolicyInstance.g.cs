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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID that Amazon Route 53 assigned to the new traffic policy instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone that Amazon Route 53 created resource record sets in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string HostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneId property is set.
        /// </summary>
        internal bool IsSetHostedZoneId() => this.HostedZoneId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The DNS name, such as www.example.com, for which Amazon Route 53 responds to queries
        /// by using the resource record sets that are associated with this traffic policy instance.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TTL. 
        /// <para>
        /// The TTL that Amazon Route 53 assigned to all of the resource record sets that it created
        /// in the specified hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public long? TTL { get; set; }

        /// <summary>
        /// Checks to see if the TTL property is set.
        /// </summary>
        internal bool IsSetTTL() => this.TTL.HasValue;

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
        [AWSProperty(Required = true)]
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// If <c>State</c> is <c>Failed</c>, an explanation of the reason for the failure. If
        /// <c>State</c> is another value, <c>Message</c> is empty.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property TrafficPolicyId. 
        /// <para>
        /// The ID of the traffic policy that Amazon Route 53 used to create resource record sets
        /// in the specified hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string TrafficPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the TrafficPolicyId property is set.
        /// </summary>
        internal bool IsSetTrafficPolicyId() => this.TrafficPolicyId != null;

        /// <summary>
        /// Gets and sets the property TrafficPolicyVersion. 
        /// <para>
        /// The version of the traffic policy that Amazon Route 53 used to create resource record
        /// sets in the specified hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public int? TrafficPolicyVersion { get; set; }

        /// <summary>
        /// Checks to see if the TrafficPolicyVersion property is set.
        /// </summary>
        internal bool IsSetTrafficPolicyVersion() => this.TrafficPolicyVersion.HasValue;

        /// <summary>
        /// Gets and sets the property TrafficPolicyType. 
        /// <para>
        /// The DNS type that Amazon Route 53 assigned to all of the resource record sets that
        /// it created for this traffic policy instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RRType TrafficPolicyType { get; set; }

        /// <summary>
        /// Checks to see if the TrafficPolicyType property is set.
        /// </summary>
        internal bool IsSetTrafficPolicyType() => this.TrafficPolicyType != null;
    }
}
