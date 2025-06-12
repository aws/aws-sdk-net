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
    /// Container for the parameters to the CreateVpcBlockPublicAccessExclusion operation.
    /// Create a VPC Block Public Access (BPA) exclusion. A VPC BPA exclusion is a mode that
    /// can be applied to a single VPC or subnet that exempts it from the account’s BPA mode
    /// and will allow bidirectional or egress-only access. You can create BPA exclusions
    /// for VPCs and subnets even when BPA is not enabled on the account to ensure that there
    /// is no traffic disruption to the exclusions when VPC BPA is turned on. To learn more
    /// about VPC BPA, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/security-vpc-bpa.html">Block
    /// public access to VPCs and subnets</a> in the <i>Amazon VPC User Guide</i>.
    /// </summary>
    public partial class CreateVpcBlockPublicAccessExclusionRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private InternetGatewayExclusionMode _internetGatewayExclusionMode;
        private string _subnetId;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private string _vpcId;

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

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// A subnet ID.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        ///  <c>tag</c> - The key/value combination of a tag assigned to the resource. Use the
        /// tag key in the filter name and the tag value as the filter value. For example, to
        /// find all resources that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>,
        /// specify <c>tag:Owner</c> for the filter name and <c>TeamA</c> for the filter value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// A VPC ID.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}