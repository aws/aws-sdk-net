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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains details about an Amazon EC2 network access control list (ACL).
    /// </summary>
    public partial class AwsEc2NetworkAclDetails
    {
        /// <summary>
        /// Gets and sets the property Associations. 
        /// <para>
        /// Associations between the network ACL and subnets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2NetworkAclAssociation> Associations { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2NetworkAclAssociation>() : null;

        /// <summary>
        /// Checks to see if the Associations property is set.
        /// </summary>
        internal bool IsSetAssociations() => this.Associations != null && (this.Associations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// The set of rules in the network ACL.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2NetworkAclEntry> Entries { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2NetworkAclEntry>() : null;

        /// <summary>
        /// Checks to see if the Entries property is set.
        /// </summary>
        internal bool IsSetEntries() => this.Entries != null && (this.Entries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Whether this is the default network ACL for the VPC.
        /// </para>
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Checks to see if the IsDefault property is set.
        /// </summary>
        internal bool IsSetIsDefault() => this.IsDefault.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkAclId. 
        /// <para>
        /// The identifier of the network ACL.
        /// </para>
        /// </summary>
        public string NetworkAclId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkAclId property is set.
        /// </summary>
        internal bool IsSetNetworkAclId() => this.NetworkAclId != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The identifier of the Amazon Web Services account that owns the network ACL.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC for the network ACL.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
