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
    /// A VPC BPA exclusion is a mode that can be applied to a single VPC or subnet that exempts
    /// it from the account’s BPA mode and will allow bidirectional or egress-only access.
    /// You can create BPA exclusions for VPCs and subnets even when BPA is not enabled on
    /// the account to ensure that there is no traffic disruption to the exclusions when VPC
    /// BPA is turned on. To learn more about VPC BPA, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/security-vpc-bpa.html">Block
    /// public access to VPCs and subnets</a> in the <i>Amazon VPC User Guide</i>.
    /// </summary>
    public partial class VpcBlockPublicAccessExclusion
    {
        private DateTime? _creationTimestamp;
        private DateTime? _deletionTimestamp;
        private string _exclusionId;
        private InternetGatewayExclusionMode _internetGatewayExclusionMode;
        private DateTime? _lastUpdateTimestamp;
        private string _reason;
        private string _resourceArn;
        private VpcBlockPublicAccessExclusionState _state;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// When the exclusion was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp
        {
            get { return this._creationTimestamp; }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletionTimestamp. 
        /// <para>
        /// When the exclusion was deleted.
        /// </para>
        /// </summary>
        public DateTime? DeletionTimestamp
        {
            get { return this._deletionTimestamp; }
            set { this._deletionTimestamp = value; }
        }

        // Check to see if DeletionTimestamp property is set
        internal bool IsSetDeletionTimestamp()
        {
            return this._deletionTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExclusionId. 
        /// <para>
        /// The ID of the exclusion.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LastUpdateTimestamp. 
        /// <para>
        /// When the exclusion was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTimestamp
        {
            get { return this._lastUpdateTimestamp; }
            set { this._lastUpdateTimestamp = value; }
        }

        // Check to see if LastUpdateTimestamp property is set
        internal bool IsSetLastUpdateTimestamp()
        {
            return this._lastUpdateTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for the current exclusion state.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the exclusion.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the exclusion.
        /// </para>
        /// </summary>
        public VpcBlockPublicAccessExclusionState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
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
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}