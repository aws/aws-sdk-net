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

namespace Amazon.PartnerCentralAccount.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConnectionInvitation operation. Creates
    /// a new connection invitation to establish a partnership with another organization.
    /// </summary>
    public partial class CreateConnectionInvitationRequest : AmazonPartnerCentralAccountRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier where the connection invitation will be created.
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
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The type of connection being requested (e.g., reseller, distributor, technology partner).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConnectionType ConnectionType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionType property is set.
        /// </summary>
        internal bool IsSetConnectionType() => this.ConnectionType != null;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address of the person to send the connection invitation to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 320)]
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A custom message to include with the connection invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the person sending the connection invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 80)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReceiverIdentifier. 
        /// <para>
        /// The identifier of the organization or partner to invite for connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ReceiverIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ReceiverIdentifier property is set.
        /// </summary>
        internal bool IsSetReceiverIdentifier() => this.ReceiverIdentifier != null;
    }
}
