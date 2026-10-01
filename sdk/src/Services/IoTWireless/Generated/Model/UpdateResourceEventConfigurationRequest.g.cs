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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResourceEventConfiguration operation. Update
    /// the event configuration for a particular resource identifier.
    /// </summary>
    public partial class UpdateResourceEventConfigurationRequest : AmazonIoTWirelessRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectionStatus. 
        /// <para>
        /// Event configuration for the connection status event.
        /// </para>
        /// </summary>
        public ConnectionStatusEventConfiguration ConnectionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionStatus property is set.
        /// </summary>
        internal bool IsSetConnectionStatus() => this.ConnectionStatus != null;

        /// <summary>
        /// Gets and sets the property DeviceRegistrationState. 
        /// <para>
        /// Event configuration for the device registration state event.
        /// </para>
        /// </summary>
        public DeviceRegistrationStateEventConfiguration DeviceRegistrationState { get; set; }

        /// <summary>
        /// Checks to see if the DeviceRegistrationState property is set.
        /// </summary>
        internal bool IsSetDeviceRegistrationState() => this.DeviceRegistrationState != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Resource identifier to opt in for event messaging.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property IdentifierType. 
        /// <para>
        /// Identifier type of the particular resource identifier for event configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IdentifierType IdentifierType { get; set; }

        /// <summary>
        /// Checks to see if the IdentifierType property is set.
        /// </summary>
        internal bool IsSetIdentifierType() => this.IdentifierType != null;

        /// <summary>
        /// Gets and sets the property Join. 
        /// <para>
        /// Event configuration for the join event.
        /// </para>
        /// </summary>
        public JoinEventConfiguration Join { get; set; }

        /// <summary>
        /// Checks to see if the Join property is set.
        /// </summary>
        internal bool IsSetJoin() => this.Join != null;

        /// <summary>
        /// Gets and sets the property MessageDeliveryStatus. 
        /// <para>
        /// Event configuration for the message delivery status event.
        /// </para>
        /// </summary>
        public MessageDeliveryStatusEventConfiguration MessageDeliveryStatus { get; set; }

        /// <summary>
        /// Checks to see if the MessageDeliveryStatus property is set.
        /// </summary>
        internal bool IsSetMessageDeliveryStatus() => this.MessageDeliveryStatus != null;

        /// <summary>
        /// Gets and sets the property PartnerType. 
        /// <para>
        /// Partner type of the resource if the identifier type is <c>PartnerAccountId</c> 
        /// </para>
        /// </summary>
        public EventNotificationPartnerType PartnerType { get; set; }

        /// <summary>
        /// Checks to see if the PartnerType property is set.
        /// </summary>
        internal bool IsSetPartnerType() => this.PartnerType != null;

        /// <summary>
        /// Gets and sets the property Proximity. 
        /// <para>
        /// Event configuration for the proximity event.
        /// </para>
        /// </summary>
        public ProximityEventConfiguration Proximity { get; set; }

        /// <summary>
        /// Checks to see if the Proximity property is set.
        /// </summary>
        internal bool IsSetProximity() => this.Proximity != null;
    }
}
