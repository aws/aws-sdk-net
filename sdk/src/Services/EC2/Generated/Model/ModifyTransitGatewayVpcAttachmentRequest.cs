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
    /// Container for the parameters to the ModifyTransitGatewayVpcAttachment operation.
    /// Modifies the specified VPC attachment.
    /// </summary>
    public partial class ModifyTransitGatewayVpcAttachmentRequest : AmazonEC2Request
    {
        private List<string> _addSubnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _dryRun;
        private ModifyTransitGatewayVpcAttachmentRequestOptions _options;
        private List<string> _removeSubnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _transitGatewayAttachmentId;

        /// <summary>
        /// Gets and sets the property AddSubnetIds. 
        /// <para>
        /// The IDs of one or more subnets to add. You can specify at most one subnet per Availability
        /// Zone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddSubnetIds
        {
            get { return this._addSubnetIds; }
            set { this._addSubnetIds = value; }
        }

        // Check to see if AddSubnetIds property is set
        internal bool IsSetAddSubnetIds()
        {
            return this._addSubnetIds != null && (this._addSubnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Gets and sets the property Options. 
        /// <para>
        /// The new VPC attachment options.
        /// </para>
        /// </summary>
        public ModifyTransitGatewayVpcAttachmentRequestOptions Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveSubnetIds. 
        /// <para>
        /// The IDs of one or more subnets to remove.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveSubnetIds
        {
            get { return this._removeSubnetIds; }
            set { this._removeSubnetIds = value; }
        }

        // Check to see if RemoveSubnetIds property is set
        internal bool IsSetRemoveSubnetIds()
        {
            return this._removeSubnetIds != null && (this._removeSubnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransitGatewayAttachmentId
        {
            get { return this._transitGatewayAttachmentId; }
            set { this._transitGatewayAttachmentId = value; }
        }

        // Check to see if TransitGatewayAttachmentId property is set
        internal bool IsSetTransitGatewayAttachmentId()
        {
            return this._transitGatewayAttachmentId != null;
        }

    }
}