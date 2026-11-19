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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyPrivateDnsNameOptions operation. Modifies
    /// the options for instance hostnames for the specified instance.
    /// </summary>
    public partial class ModifyPrivateDnsNameOptionsRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property EnableResourceNameDnsAAAARecord. 
        /// <para>
        /// Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records.
        /// </para>
        /// </summary>
        public bool? EnableResourceNameDnsAAAARecord { get; set; }

        /// <summary>
        /// Checks to see if the EnableResourceNameDnsAAAARecord property is set.
        /// </summary>
        internal bool IsSetEnableResourceNameDnsAAAARecord() => this.EnableResourceNameDnsAAAARecord.HasValue;

        /// <summary>
        /// Gets and sets the property EnableResourceNameDnsARecord. 
        /// <para>
        /// Indicates whether to respond to DNS queries for instance hostnames with DNS A records.
        /// </para>
        /// </summary>
        public bool? EnableResourceNameDnsARecord { get; set; }

        /// <summary>
        /// Checks to see if the EnableResourceNameDnsARecord property is set.
        /// </summary>
        internal bool IsSetEnableResourceNameDnsARecord() => this.EnableResourceNameDnsARecord.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property PrivateDnsHostnameType. 
        /// <para>
        /// The type of hostname for EC2 instances. For IPv4 only subnets, an instance DNS name
        /// must be based on the instance IPv4 address. For IPv6 only subnets, an instance DNS
        /// name must be based on the instance ID. For dual-stack subnets, you can specify whether
        /// DNS names use the instance IPv4 address or the instance ID.
        /// </para>
        /// </summary>
        public HostnameType PrivateDnsHostnameType { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsHostnameType property is set.
        /// </summary>
        internal bool IsSetPrivateDnsHostnameType() => this.PrivateDnsHostnameType != null;
    }
}
