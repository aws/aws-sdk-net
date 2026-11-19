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
    /// This is the response object from the DescribeNetworkInterfaceAttribute operation.
    /// </summary>
    public partial class DescribeNetworkInterfaceAttributeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssociatePublicIpAddress. 
        /// <para>
        /// Indicates whether to assign a public IPv4 address to a network interface. This option
        /// can be enabled for any network interface but will only apply to the primary network
        /// interface (eth0).
        /// </para>
        /// </summary>
        public bool? AssociatePublicIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the AssociatePublicIpAddress property is set.
        /// </summary>
        internal bool IsSetAssociatePublicIpAddress() => this.AssociatePublicIpAddress.HasValue;

        /// <summary>
        /// Gets and sets the property Attachment. 
        /// <para>
        /// The attachment (if any) of the network interface.
        /// </para>
        /// </summary>
        public NetworkInterfaceAttachment Attachment { get; set; }

        /// <summary>
        /// Checks to see if the Attachment property is set.
        /// </summary>
        internal bool IsSetAttachment() => this.Attachment != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the network interface.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// The security groups associated with the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GroupIdentifier> Groups { get; set; } = AWSConfigs.InitializeCollections ? new List<GroupIdentifier>() : null;

        /// <summary>
        /// Checks to see if the Groups property is set.
        /// </summary>
        internal bool IsSetGroups() => this.Groups != null && (this.Groups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;

        /// <summary>
        /// Gets and sets the property SourceDestCheck. 
        /// <para>
        /// Indicates whether source/destination checking is enabled.
        /// </para>
        /// </summary>
        public bool? SourceDestCheck { get; set; }

        /// <summary>
        /// Checks to see if the SourceDestCheck property is set.
        /// </summary>
        internal bool IsSetSourceDestCheck() => this.SourceDestCheck.HasValue;
    }
}
