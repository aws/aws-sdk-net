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
    /// Describes an association between a local gateway route table and a VPC.
    /// </summary>
    public partial class LocalGatewayRouteTableVpcAssociation
    {
        private string _localGatewayId;
        private string _localGatewayRouteTableArn;
        private string _localGatewayRouteTableId;
        private string _localGatewayRouteTableVpcAssociationId;
        private string _ownerId;
        private string _state;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property LocalGatewayId. 
        /// <para>
        /// The ID of the local gateway.
        /// </para>
        /// </summary>
        public string LocalGatewayId
        {
            get { return this._localGatewayId; }
            set { this._localGatewayId = value; }
        }

        // Check to see if LocalGatewayId property is set
        internal bool IsSetLocalGatewayId()
        {
            return this._localGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property LocalGatewayRouteTableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the local gateway route table for the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string LocalGatewayRouteTableArn
        {
            get { return this._localGatewayRouteTableArn; }
            set { this._localGatewayRouteTableArn = value; }
        }

        // Check to see if LocalGatewayRouteTableArn property is set
        internal bool IsSetLocalGatewayRouteTableArn()
        {
            return this._localGatewayRouteTableArn != null;
        }

        /// <summary>
        /// Gets and sets the property LocalGatewayRouteTableId. 
        /// <para>
        /// The ID of the local gateway route table.
        /// </para>
        /// </summary>
        public string LocalGatewayRouteTableId
        {
            get { return this._localGatewayRouteTableId; }
            set { this._localGatewayRouteTableId = value; }
        }

        // Check to see if LocalGatewayRouteTableId property is set
        internal bool IsSetLocalGatewayRouteTableId()
        {
            return this._localGatewayRouteTableId != null;
        }

        /// <summary>
        /// Gets and sets the property LocalGatewayRouteTableVpcAssociationId. 
        /// <para>
        /// The ID of the association.
        /// </para>
        /// </summary>
        public string LocalGatewayRouteTableVpcAssociationId
        {
            get { return this._localGatewayRouteTableVpcAssociationId; }
            set { this._localGatewayRouteTableVpcAssociationId = value; }
        }

        // Check to see if LocalGatewayRouteTableVpcAssociationId property is set
        internal bool IsSetLocalGatewayRouteTableVpcAssociationId()
        {
            return this._localGatewayRouteTableVpcAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the local gateway route table
        /// for the association.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the association.
        /// </para>
        /// </summary>
        public string State
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
        /// The tags assigned to the association.
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

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
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