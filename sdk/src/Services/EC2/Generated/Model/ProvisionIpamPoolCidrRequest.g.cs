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
    /// Container for the parameters to the ProvisionIpamPoolCidr operation. Provision a CIDR
    /// to an IPAM pool. You can use this action to provision new CIDRs to a top-level pool
    /// or to transfer a CIDR from a top-level pool to a pool within it. <para> For more information,
    /// see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/prov-cidr-ipam.html">Provision
    /// CIDRs to pools</a> in the <i>Amazon VPC IPAM User Guide</i>. </para>
    /// </summary>
    public partial class ProvisionIpamPoolCidrRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The CIDR you want to assign to the IPAM pool. Either "NetmaskLength" or "Cidr" is
        /// required. This value will be null if you specify "NetmaskLength" and will be filled
        /// in during the provisioning process.
        /// </para>
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// Checks to see if the Cidr property is set.
        /// </summary>
        internal bool IsSetCidr() => this.Cidr != null;

        /// <summary>
        /// Gets and sets the property CidrAuthorizationContext. 
        /// <para>
        /// A signed document that proves that you are authorized to bring a specified IP address
        /// range to Amazon using BYOIP. This option only applies to IPv4 and IPv6 pools in the
        /// public scope.
        /// </para>
        /// </summary>
        public IpamCidrAuthorizationContext CidrAuthorizationContext { get; set; }

        /// <summary>
        /// Checks to see if the CidrAuthorizationContext property is set.
        /// </summary>
        internal bool IsSetCidrAuthorizationContext() => this.CidrAuthorizationContext != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property IpamExternalResourceVerificationTokenId. 
        /// <para>
        /// Verification token ID. This option only applies to IPv4 and IPv6 pools in the public
        /// scope.
        /// </para>
        /// </summary>
        public string IpamExternalResourceVerificationTokenId { get; set; }

        /// <summary>
        /// Checks to see if the IpamExternalResourceVerificationTokenId property is set.
        /// </summary>
        internal bool IsSetIpamExternalResourceVerificationTokenId() => this.IpamExternalResourceVerificationTokenId != null;

        /// <summary>
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The ID of the IPAM pool to which you want to assign a CIDR.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IpamPoolId { get; set; }

        /// <summary>
        /// Checks to see if the IpamPoolId property is set.
        /// </summary>
        internal bool IsSetIpamPoolId() => this.IpamPoolId != null;

        /// <summary>
        /// Gets and sets the property NetmaskLength. 
        /// <para>
        /// The netmask length of the CIDR you'd like to provision to a pool. Can be used for
        /// provisioning Amazon-provided IPv6 CIDRs to top-level pools and for provisioning CIDRs
        /// to pools with source pools. Cannot be used to provision BYOIP CIDRs to top-level pools.
        /// Either "NetmaskLength" or "Cidr" is required.
        /// </para>
        /// </summary>
        public int? NetmaskLength { get; set; }

        /// <summary>
        /// Checks to see if the NetmaskLength property is set.
        /// </summary>
        internal bool IsSetNetmaskLength() => this.NetmaskLength.HasValue;

        /// <summary>
        /// Gets and sets the property VerificationMethod. 
        /// <para>
        /// The method for verifying control of a public IP address range. Defaults to <c>remarks-x509</c>
        /// if not specified. This option only applies to IPv4 and IPv6 pools in the public scope.
        /// </para>
        /// </summary>
        public VerificationMethod VerificationMethod { get; set; }

        /// <summary>
        /// Checks to see if the VerificationMethod property is set.
        /// </summary>
        internal bool IsSetVerificationMethod() => this.VerificationMethod != null;
    }
}
