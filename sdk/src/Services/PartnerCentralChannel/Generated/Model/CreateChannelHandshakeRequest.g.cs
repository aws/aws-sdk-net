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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateChannelHandshake operation. Creates a new
    /// channel handshake request to establish a partnership with another AWS account.
    /// </summary>
    public partial class CreateChannelHandshakeRequest : AmazonPartnerCentralChannelRequest
    {
        /// <summary>
        /// Gets and sets the property AssociatedResourceIdentifier. 
        /// <para>
        /// The identifier of the resource associated with this handshake.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 16, Max = 1011)]
        public string AssociatedResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetAssociatedResourceIdentifier() => this.AssociatedResourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier for the handshake request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property HandshakeType. 
        /// <para>
        /// The type of handshake to create (e.g., start service period, revoke service period).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HandshakeType HandshakeType { get; set; }

        /// <summary>
        /// Checks to see if the HandshakeType property is set.
        /// </summary>
        internal bool IsSetHandshakeType() => this.HandshakeType != null;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The payload containing specific details for the handshake type.
        /// </para>
        /// </summary>
        public ChannelHandshakePayload Payload { get; set; }

        /// <summary>
        /// Checks to see if the Payload property is set.
        /// </summary>
        internal bool IsSetPayload() => this.Payload != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs to associate with the channel handshake.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
