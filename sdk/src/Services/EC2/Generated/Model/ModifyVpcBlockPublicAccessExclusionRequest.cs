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
    /// Container for the parameters to the ModifyVpcBlockPublicAccessExclusion operation.
    /// Modify VPC Block Public Access (BPA) exclusions. A VPC BPA exclusion is a mode that
    /// can be applied to a single VPC or subnet that exempts it from the account’s BPA mode
    /// and will allow bidirectional or egress-only access. You can create BPA exclusions
    /// for VPCs and subnets even when BPA is not enabled on the account to ensure that there
    /// is no traffic disruption to the exclusions when VPC BPA is turned on.
    /// </summary>
    public partial class ModifyVpcBlockPublicAccessExclusionRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _exclusionId;
        private InternetGatewayExclusionMode _internetGatewayExclusionMode;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
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
        /// Gets and sets the property ExclusionId. 
        /// <para>
        /// The ID of an exclusion.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExclusionId
        {
            get { return this._exclusionId; }
            set { this._exclusionId = value; }
        }

        // Check to see if ExclusionId property is set
        internal bool IsSetExclusionId()
        {
            return this._exclusionId != null;
        }

        /// <summary>
        /// Gets and sets the property InternetGatewayExclusionMode. 
        /// <para>
        /// The exclusion mode for internet gateway traffic.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>allow-bidirectional</c>: Allow all internet traffic to and from the excluded VPCs
        /// and subnets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>allow-egress</c>: Allow outbound internet traffic from the excluded VPCs and subnets.
        /// Block inbound internet traffic to the excluded VPCs and subnets. Only applies when
        /// VPC Block Public Access is set to Bidirectional.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public InternetGatewayExclusionMode InternetGatewayExclusionMode
        {
            get { return this._internetGatewayExclusionMode; }
            set { this._internetGatewayExclusionMode = value; }
        }

        // Check to see if InternetGatewayExclusionMode property is set
        internal bool IsSetInternetGatewayExclusionMode()
        {
            return this._internetGatewayExclusionMode != null;
        }

    }
}