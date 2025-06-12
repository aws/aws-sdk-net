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
    /// Describes a transit gateway route table.
    /// </summary>
    public partial class TransitGatewayRouteTable
    {
        private DateTime? _creationTime;
        private bool? _defaultAssociationRouteTable;
        private bool? _defaultPropagationRouteTable;
        private TransitGatewayRouteTableState _state;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _transitGatewayId;
        private string _transitGatewayRouteTableId;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultAssociationRouteTable. 
        /// <para>
        /// Indicates whether this is the default association route table for the transit gateway.
        /// </para>
        /// </summary>
        public bool? DefaultAssociationRouteTable
        {
            get { return this._defaultAssociationRouteTable; }
            set { this._defaultAssociationRouteTable = value; }
        }

        // Check to see if DefaultAssociationRouteTable property is set
        internal bool IsSetDefaultAssociationRouteTable()
        {
            return this._defaultAssociationRouteTable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultPropagationRouteTable. 
        /// <para>
        /// Indicates whether this is the default propagation route table for the transit gateway.
        /// </para>
        /// </summary>
        public bool? DefaultPropagationRouteTable
        {
            get { return this._defaultPropagationRouteTable; }
            set { this._defaultPropagationRouteTable = value; }
        }

        // Check to see if DefaultPropagationRouteTable property is set
        internal bool IsSetDefaultPropagationRouteTable()
        {
            return this._defaultPropagationRouteTable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the transit gateway route table.
        /// </para>
        /// </summary>
        public TransitGatewayRouteTableState State
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
        /// Any tags assigned to the route table.
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
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of the transit gateway.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property TransitGatewayRouteTableId. 
        /// <para>
        /// The ID of the transit gateway route table.
        /// </para>
        /// </summary>
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