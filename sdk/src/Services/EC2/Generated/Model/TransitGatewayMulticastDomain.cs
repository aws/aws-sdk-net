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
    /// Describes the transit gateway multicast domain.
    /// </summary>
    public partial class TransitGatewayMulticastDomain
    {
        private DateTime? _creationTime;
        private TransitGatewayMulticastDomainOptions _options;
        private string _ownerId;
        private TransitGatewayMulticastDomainState _state;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _transitGatewayId;
        private string _transitGatewayMulticastDomainArn;
        private string _transitGatewayMulticastDomainId;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the transit gateway multicast domain was created.
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
        /// Gets and sets the property Options. 
        /// <para>
        /// The options for the transit gateway multicast domain.
        /// </para>
        /// </summary>
        public TransitGatewayMulticastDomainOptions Options
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
        /// Gets and sets the property OwnerId. 
        /// <para>
        ///  The ID of the Amazon Web Services account that owns the transit gateway multicast
        /// domain.
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
        /// The state of the transit gateway multicast domain.
        /// </para>
        /// </summary>
        public TransitGatewayMulticastDomainState State
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
        /// The tags for the transit gateway multicast domain.
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
        /// Gets and sets the property TransitGatewayMulticastDomainArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the transit gateway multicast domain.
        /// </para>
        /// </summary>
        public string TransitGatewayMulticastDomainArn
        {
            get { return this._transitGatewayMulticastDomainArn; }
            set { this._transitGatewayMulticastDomainArn = value; }
        }

        // Check to see if TransitGatewayMulticastDomainArn property is set
        internal bool IsSetTransitGatewayMulticastDomainArn()
        {
            return this._transitGatewayMulticastDomainArn != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayMulticastDomainId. 
        /// <para>
        /// The ID of the transit gateway multicast domain.
        /// </para>
        /// </summary>
        public string TransitGatewayMulticastDomainId
        {
            get { return this._transitGatewayMulticastDomainId; }
            set { this._transitGatewayMulticastDomainId = value; }
        }

        // Check to see if TransitGatewayMulticastDomainId property is set
        internal bool IsSetTransitGatewayMulticastDomainId()
        {
            return this._transitGatewayMulticastDomainId != null;
        }

    }
}