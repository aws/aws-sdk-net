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
    /// Container for the parameters to the CreateEndpoint operation. Creates an endpoint
    /// and associates it with the specified Outpost. <note> <para> It can take up to 5 minutes
    /// for this action to finish. </para> </note> <para> </para> <para> Related actions include:
    /// </para> <ul> <li> <para> <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_DeleteEndpoint.html">DeleteEndpoint</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_ListEndpoints.html">ListEndpoints</a>
    /// </para> </li> </ul>
    /// </summary>
    public partial class CreateEndpointRequest : AmazonS3OutpostsRequest
    {
        /// <summary>
        /// Gets and sets the property AccessType. 
        /// <para>
        /// The type of access for the network connectivity for the Amazon S3 on Outposts endpoint.
        /// To use the Amazon Web Services VPC, choose <c>Private</c>. To use the endpoint with
        /// an on-premises network, choose <c>CustomerOwnedIp</c>. If you choose <c>CustomerOwnedIp</c>,
        /// you must also provide the customer-owned IP address pool (CoIP pool).
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>Private</c> is the default access type value.
        /// </para>
        ///  </note>
        /// </summary>
        public EndpointAccessType AccessType { get; set; }

        /// <summary>
        /// Checks to see if the AccessType property is set.
        /// </summary>
        internal bool IsSetAccessType() => this.AccessType != null;

        /// <summary>
        /// Gets and sets the property CustomerOwnedIpv4Pool. 
        /// <para>
        /// The ID of the customer-owned IPv4 address pool (CoIP pool) for the endpoint. IP addresses
        /// are allocated from this pool for the endpoint.
        /// </para>
        /// </summary>
        public string CustomerOwnedIpv4Pool { get; set; }

        /// <summary>
        /// Checks to see if the CustomerOwnedIpv4Pool property is set.
        /// </summary>
        internal bool IsSetCustomerOwnedIpv4Pool() => this.CustomerOwnedIpv4Pool != null;

        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        /// The ID of the Outposts. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OutpostId { get; set; }

        /// <summary>
        /// Checks to see if the OutpostId property is set.
        /// </summary>
        internal bool IsSetOutpostId() => this.OutpostId != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupId. 
        /// <para>
        /// The ID of the security group to use with the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroupId property is set.
        /// </summary>
        internal bool IsSetSecurityGroupId() => this.SecurityGroupId != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet in the selected VPC. The endpoint subnet must belong to the Outpost
        /// that has Amazon S3 on Outposts provisioned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;
    }
}
