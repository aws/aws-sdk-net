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
    /// Describes a secondary network.
    /// </summary>
    public partial class SecondaryNetwork
    {
        /// <summary>
        /// Gets and sets the property Ipv4CidrBlockAssociations. 
        /// <para>
        /// Information about the IPv4 CIDR blocks associated with the secondary network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SecondaryNetworkIpv4CidrBlockAssociation> Ipv4CidrBlockAssociations { get; set; } = AWSConfigs.InitializeCollections ? new List<SecondaryNetworkIpv4CidrBlockAssociation>() : null;

        /// <summary>
        /// Checks to see if the Ipv4CidrBlockAssociations property is set.
        /// </summary>
        internal bool IsSetIpv4CidrBlockAssociations() => this.Ipv4CidrBlockAssociations != null && (this.Ipv4CidrBlockAssociations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the secondary network.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property SecondaryNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the secondary network.
        /// </para>
        /// </summary>
        public string SecondaryNetworkArn { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryNetworkArn property is set.
        /// </summary>
        internal bool IsSetSecondaryNetworkArn() => this.SecondaryNetworkArn != null;

        /// <summary>
        /// Gets and sets the property SecondaryNetworkId. 
        /// <para>
        /// The ID of the secondary network.
        /// </para>
        /// </summary>
        public string SecondaryNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryNetworkId property is set.
        /// </summary>
        internal bool IsSetSecondaryNetworkId() => this.SecondaryNetworkId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the secondary network.
        /// </para>
        /// </summary>
        public SecondaryNetworkState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason for the current state of the secondary network.
        /// </para>
        /// </summary>
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the secondary network.
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the secondary network.
        /// </para>
        /// </summary>
        public SecondaryNetworkType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
