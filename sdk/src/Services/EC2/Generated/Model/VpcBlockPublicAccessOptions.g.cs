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
    /// VPC Block Public Access (BPA) enables you to block resources in VPCs and subnets that
    /// you own in a Region from reaching or being reached from the internet through internet
    /// gateways and egress-only internet gateways. To learn more about VPC BPA, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/security-vpc-bpa.html">Block
    /// public access to VPCs and subnets</a> in the <i>Amazon VPC User Guide</i>.
    /// </summary>
    public partial class VpcBlockPublicAccessOptions
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// An Amazon Web Services account ID.
        /// </para>
        /// </summary>
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// An Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string AwsRegion { get; set; }

        /// <summary>
        /// Checks to see if the AwsRegion property is set.
        /// </summary>
        internal bool IsSetAwsRegion() => this.AwsRegion != null;

        /// <summary>
        /// Gets and sets the property ExclusionsAllowed. 
        /// <para>
        /// Determines if exclusions are allowed. If you have <a href="https://docs.aws.amazon.com/vpc/latest/userguide/security-vpc-bpa.html#security-vpc-bpa-exclusions-orgs">enabled
        /// VPC BPA at the Organization level</a>, exclusions may be <c>not-allowed</c>. Otherwise,
        /// they are <c>allowed</c>.
        /// </para>
        /// </summary>
        public VpcBlockPublicAccessExclusionsAllowed ExclusionsAllowed { get; set; }

        /// <summary>
        /// Checks to see if the ExclusionsAllowed property is set.
        /// </summary>
        internal bool IsSetExclusionsAllowed() => this.ExclusionsAllowed != null;

        /// <summary>
        /// Gets and sets the property InternetGatewayBlockMode. 
        /// <para>
        /// The current mode of VPC BPA.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>off</c>: VPC BPA is not enabled and traffic is allowed to and from internet gateways
        /// and egress-only internet gateways in this Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>block-bidirectional</c>: Block all traffic to and from internet gateways and egress-only
        /// internet gateways in this Region (except for excluded VPCs and subnets).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>block-ingress</c>: Block all internet traffic to the VPCs in this Region (except
        /// for VPCs or subnets which are excluded). Only traffic to and from NAT gateways and
        /// egress-only internet gateways is allowed because these gateways only allow outbound
        /// connections to be established.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InternetGatewayBlockMode InternetGatewayBlockMode { get; set; }

        /// <summary>
        /// Checks to see if the InternetGatewayBlockMode property is set.
        /// </summary>
        internal bool IsSetInternetGatewayBlockMode() => this.InternetGatewayBlockMode != null;

        /// <summary>
        /// Gets and sets the property LastUpdateTimestamp. 
        /// <para>
        /// The last time the VPC BPA mode was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdateTimestamp() => this.LastUpdateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// The entity that manages the state of VPC BPA. Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>account</c> - The state is managed by the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>declarative-policy</c> - The state is managed by a declarative policy and can't
        /// be modified by the account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Checks to see if the ManagedBy property is set.
        /// </summary>
        internal bool IsSetManagedBy() => this.ManagedBy != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for the current state.
        /// </para>
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of VPC BPA.
        /// </para>
        /// </summary>
        public VpcBlockPublicAccessState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
