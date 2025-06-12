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
    /// Container for the parameters to the CreateTransitGatewayPeeringAttachment operation.
    /// Requests a transit gateway peering attachment between the specified transit gateway
    /// (requester) and a peer transit gateway (accepter). The peer transit gateway can be
    /// in your account or a different Amazon Web Services account.
    /// 
    ///  
    /// <para>
    /// After you create the peering attachment, the owner of the accepter transit gateway
    /// must accept the attachment request.
    /// </para>
    /// </summary>
    public partial class CreateTransitGatewayPeeringAttachmentRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private CreateTransitGatewayPeeringAttachmentRequestOptions _options;
        private string _peerAccountId;
        private string _peerRegion;
        private string _peerTransitGatewayId;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private string _transitGatewayId;

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
        /// Requests a transit gateway peering attachment.
        /// </para>
        /// </summary>
        public CreateTransitGatewayPeeringAttachmentRequestOptions Options
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
        /// Gets and sets the property PeerAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the peer transit gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PeerAccountId
        {
            get { return this._peerAccountId; }
            set { this._peerAccountId = value; }
        }

        // Check to see if PeerAccountId property is set
        internal bool IsSetPeerAccountId()
        {
            return this._peerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property PeerRegion. 
        /// <para>
        /// The Region where the peer transit gateway is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PeerRegion
        {
            get { return this._peerRegion; }
            set { this._peerRegion = value; }
        }

        // Check to see if PeerRegion property is set
        internal bool IsSetPeerRegion()
        {
            return this._peerRegion != null;
        }

        /// <summary>
        /// Gets and sets the property PeerTransitGatewayId. 
        /// <para>
        /// The ID of the peer transit gateway with which to create the peering attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PeerTransitGatewayId
        {
            get { return this._peerTransitGatewayId; }
            set { this._peerTransitGatewayId = value; }
        }

        // Check to see if PeerTransitGatewayId property is set
        internal bool IsSetPeerTransitGatewayId()
        {
            return this._peerTransitGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the transit gateway peering attachment.
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
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of the transit gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransitGatewayId
        {
            get { return this._transitGatewayId; }
            set { this._transitGatewayId = value; }
        }

        // Check to see if TransitGatewayId property is set
        internal bool IsSetTransitGatewayId()
        {
            return this._transitGatewayId != null;
        }

    }
}