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

namespace Amazon.S3Outposts.Model
{
    /// <summary>
    /// Amazon S3 on Outposts Access Points simplify managing data access at scale for shared
    /// datasets in S3 on Outposts. S3 on Outposts uses endpoints to connect to Outposts buckets
    /// so that you can perform actions within your virtual private cloud (VPC). For more
    /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/WorkingWithS3Outposts.html">
    /// Accessing S3 on Outposts using VPC-only access points</a> in the <i>Amazon Simple
    /// Storage Service User Guide</i>.
    /// </summary>
    public partial class Endpoint
    {
        /// <summary>
        /// Gets and sets the property AccessType. 
        /// <para>
        /// The type of connectivity used to access the Amazon S3 on Outposts endpoint.
        /// </para>
        /// </summary>
        public EndpointAccessType AccessType { get; set; }

        /// <summary>
        /// Checks to see if the AccessType property is set.
        /// </summary>
        internal bool IsSetAccessType() => this.AccessType != null;

        /// <summary>
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// The VPC CIDR committed by this endpoint.
        /// </para>
        /// </summary>
        public string CidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the CidrBlock property is set.
        /// </summary>
        internal bool IsSetCidrBlock() => this.CidrBlock != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the endpoint was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerOwnedIpv4Pool. 
        /// <para>
        /// The ID of the customer-owned IPv4 address pool used for the endpoint.
        /// </para>
        /// </summary>
        public string CustomerOwnedIpv4Pool { get; set; }

        /// <summary>
        /// Checks to see if the CustomerOwnedIpv4Pool property is set.
        /// </summary>
        internal bool IsSetCustomerOwnedIpv4Pool() => this.CustomerOwnedIpv4Pool != null;

        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint.
        /// </para>
        /// </summary>
        public string EndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the EndpointArn property is set.
        /// </summary>
        internal bool IsSetEndpointArn() => this.EndpointArn != null;

        /// <summary>
        /// Gets and sets the property FailedReason. 
        /// <para>
        /// The failure reason, if any, for a create or delete endpoint operation.
        /// </para>
        /// </summary>
        public FailedReason FailedReason { get; set; }

        /// <summary>
        /// Checks to see if the FailedReason property is set.
        /// </summary>
        internal bool IsSetFailedReason() => this.FailedReason != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// The network interface of the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkInterface> NetworkInterfaces { get; set; } = AWSConfigs.InitializeCollections ? new List<NetworkInterface>() : null;

        /// <summary>
        /// Checks to see if the NetworkInterfaces property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaces() => this.NetworkInterfaces != null && (this.NetworkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutpostsId. 
        /// <para>
        /// The ID of the Outposts.
        /// </para>
        /// </summary>
        public string OutpostsId { get; set; }

        /// <summary>
        /// Checks to see if the OutpostsId property is set.
        /// </summary>
        internal bool IsSetOutpostsId() => this.OutpostsId != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupId. 
        /// <para>
        /// The ID of the security group used for the endpoint.
        /// </para>
        /// </summary>
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroupId property is set.
        /// </summary>
        internal bool IsSetSecurityGroupId() => this.SecurityGroupId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the endpoint.
        /// </para>
        /// </summary>
        public EndpointStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet used for the endpoint.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC used for the endpoint.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
