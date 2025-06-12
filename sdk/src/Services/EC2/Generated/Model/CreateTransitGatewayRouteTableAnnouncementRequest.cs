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
    /// Container for the parameters to the CreateTransitGatewayRouteTableAnnouncement operation.
    /// Advertises a new transit gateway route table.
    /// </summary>
    public partial class CreateTransitGatewayRouteTableAnnouncementRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _peeringAttachmentId;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private string _transitGatewayRouteTableId;

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
        /// Gets and sets the property PeeringAttachmentId. 
        /// <para>
        /// The ID of the peering attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PeeringAttachmentId
        {
            get { return this._peeringAttachmentId; }
            set { this._peeringAttachmentId = value; }
        }

        // Check to see if PeeringAttachmentId property is set
        internal bool IsSetPeeringAttachmentId()
        {
            return this._peeringAttachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags specifications applied to the transit gateway route table announcement.
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
        /// Gets and sets the property TransitGatewayRouteTableId. 
        /// <para>
        /// The ID of the transit gateway route table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransitGatewayRouteTableId
        {
            get { return this._transitGatewayRouteTableId; }
            set { this._transitGatewayRouteTableId = value; }
        }

        // Check to see if TransitGatewayRouteTableId property is set
        internal bool IsSetTransitGatewayRouteTableId()
        {
            return this._transitGatewayRouteTableId != null;
        }

    }
}