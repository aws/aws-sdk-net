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
    /// Information about an IPAM policy.
    /// 
    ///  
    /// <para>
    /// An IPAM policy is a set of rules that define how public IPv4 addresses from IPAM pools
    /// are allocated to Amazon Web Services resources. Each rule maps an Amazon Web Services
    /// service to IPAM pools that the service will use to get IP addresses. A single policy
    /// can have multiple rules and be applied to multiple Amazon Web Services Regions. If
    /// the IPAM pool run out of addresses then the services fallback to Amazon-provided IP
    /// addresses. A policy can be applied to an individual Amazon Web Services account or
    /// an entity within Amazon Web Services Organizations.
    /// </para>
    /// </summary>
    public partial class IpamPolicy
    {
        /// <summary>
        /// Gets and sets the property IpamId. 
        /// <para>
        /// The ID of the IPAM this policy belongs to.
        /// </para>
        /// </summary>
        public string IpamId { get; set; }

        /// <summary>
        /// Checks to see if the IpamId property is set.
        /// </summary>
        internal bool IsSetIpamId() => this.IpamId != null;

        /// <summary>
        /// Gets and sets the property IpamPolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IPAM policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string IpamPolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the IpamPolicyArn property is set.
        /// </summary>
        internal bool IsSetIpamPolicyArn() => this.IpamPolicyArn != null;

        /// <summary>
        /// Gets and sets the property IpamPolicyId. 
        /// <para>
        /// The ID of the IPAM policy.
        /// </para>
        /// </summary>
        public string IpamPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the IpamPolicyId property is set.
        /// </summary>
        internal bool IsSetIpamPolicyId() => this.IpamPolicyId != null;

        /// <summary>
        /// Gets and sets the property IpamPolicyRegion. 
        /// <para>
        /// The Region of the IPAM policy.
        /// </para>
        /// </summary>
        public string IpamPolicyRegion { get; set; }

        /// <summary>
        /// Checks to see if the IpamPolicyRegion property is set.
        /// </summary>
        internal bool IsSetIpamPolicyRegion() => this.IpamPolicyRegion != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The account ID that owns the IPAM policy.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the IPAM policy.
        /// </para>
        /// </summary>
        public IpamPolicyState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// A message about the state of the IPAM policy.
        /// </para>
        /// </summary>
        public string StateMessage { get; set; }

        /// <summary>
        /// Checks to see if the StateMessage property is set.
        /// </summary>
        internal bool IsSetStateMessage() => this.StateMessage != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the IPAM policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
