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
    /// Container for the parameters to the CreateTrafficPolicyInstance operation. Creates
    /// resource record sets in a specified hosted zone based on the settings in a specified
    /// traffic policy version. In addition, <c>CreateTrafficPolicyInstance</c> associates
    /// the resource record sets with a specified domain name (such as example.com) or subdomain
    /// name (such as www.example.com). Amazon Route 53 responds to DNS queries for the domain
    /// or subdomain name by using the resource record sets that <c>CreateTrafficPolicyInstance</c>
    /// created. <note> <para> After you submit an <c>CreateTrafficPolicyInstance</c> request,
    /// there's a brief delay while Amazon Route 53 creates the resource record sets that
    /// are specified in the traffic policy definition. Use <c>GetTrafficPolicyInstance</c>
    /// with the <c>id</c> of new traffic policy instance to confirm that the <c>CreateTrafficPolicyInstance</c>
    /// request completed successfully. For more information, see the <c>State</c> response
    /// element. </para> </note>
    /// </summary>
    public partial class CreateTrafficPolicyInstanceRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone that you want Amazon Route 53 to create resource record
        /// sets in by using the configuration in a traffic policy.
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
        /// The domain name (such as example.com) or subdomain name (such as www.example.com)
        /// for which Amazon Route 53 responds to DNS queries by using the resource record sets
        /// that Route 53 creates for this traffic policy instance.
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
        /// (Optional) The TTL that you want Amazon Route 53 to assign to all of the resource
        /// record sets that it creates in the specified hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public long? TTL { get; set; }

        /// <summary>
        /// Checks to see if the TTL property is set.
        /// </summary>
        internal bool IsSetTTL() => this.TTL.HasValue;

        /// <summary>
        /// Gets and sets the property TrafficPolicyId. 
        /// <para>
        /// The ID of the traffic policy that you want to use to create resource record sets in
        /// the specified hosted zone.
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
        /// The version of the traffic policy that you want to use to create resource record sets
        /// in the specified hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public int? TrafficPolicyVersion { get; set; }

        /// <summary>
        /// Checks to see if the TrafficPolicyVersion property is set.
        /// </summary>
        internal bool IsSetTrafficPolicyVersion() => this.TrafficPolicyVersion.HasValue;
    }
}
