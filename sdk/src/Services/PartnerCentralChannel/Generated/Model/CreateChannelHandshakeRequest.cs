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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
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
namespace Amazon.PartnerCentralChannel.Model
{
    /// <summary>
    /// Container for the parameters to the CreateChannelHandshake operation.
    /// Creates a new channel handshake request to establish a partnership with another AWS
    /// account.
    /// </summary>
    public partial class CreateChannelHandshakeRequest : AmazonPartnerCentralChannelRequest
    {
        private string _associatedResourceIdentifier;
        private string _catalog;
        private string _clientToken;
        private HandshakeType _handshakeType;
        private ChannelHandshakePayload _payload;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AssociatedResourceIdentifier. 
        /// <para>
        /// The identifier of the resource associated with this handshake.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=1011)]
        public string AssociatedResourceIdentifier
        {
            get { return this._associatedResourceIdentifier; }
            set { this._associatedResourceIdentifier = value; }
        }

        // Check to see if AssociatedResourceIdentifier property is set
        internal bool IsSetAssociatedResourceIdentifier()
        {
            return this._associatedResourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier for the handshake request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property HandshakeType. 
        /// <para>
        /// The type of handshake to create (e.g., start service period, revoke service period).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HandshakeType HandshakeType
        {
            get { return this._handshakeType; }
            set { this._handshakeType = value; }
        }

        // Check to see if HandshakeType property is set
        internal bool IsSetHandshakeType()
        {
            return this._handshakeType != null;
        }

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The payload containing specific details for the handshake type.
        /// </para>
        /// </summary>
        public ChannelHandshakePayload Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs to associate with the channel handshake.
        /// </para>
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