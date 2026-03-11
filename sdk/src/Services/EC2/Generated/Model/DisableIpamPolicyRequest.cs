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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the DisableIpamPolicy operation.
    /// Disables an IPAM policy.
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
    public partial class DisableIpamPolicyRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _ipamPolicyId;
        private string _organizationTargetId;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpamPolicyId. 
        /// <para>
        /// The ID of the IPAM policy to disable.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamPolicyId
        {
            get { return this._ipamPolicyId; }
            set { this._ipamPolicyId = value; }
        }

        // Check to see if IpamPolicyId property is set
        internal bool IsSetIpamPolicyId()
        {
            return this._ipamPolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationTargetId. 
        /// <para>
        /// The ID of the Amazon Web Services Organizations target for which to disable the IPAM
        /// policy. This parameter is required only when IPAM is integrated with Amazon Web Services
        /// Organizations. When IPAM is not integrated with Amazon Web Services Organizations,
        /// omit this parameter and the policy will be disabled for the current account.
        /// </para>
        ///  
        /// <para>
        /// A target can be an individual Amazon Web Services account or an entity within an Amazon
        /// Web Services Organization to which an IPAM policy can be applied.
        /// </para>
        /// </summary>
        public string OrganizationTargetId
        {
            get { return this._organizationTargetId; }
            set { this._organizationTargetId = value; }
        }

        // Check to see if OrganizationTargetId property is set
        internal bool IsSetOrganizationTargetId()
        {
            return this._organizationTargetId != null;
        }

    }
}