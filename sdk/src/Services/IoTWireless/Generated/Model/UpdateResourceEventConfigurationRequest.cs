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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResourceEventConfiguration operation.
    /// Update the event configuration for a particular resource identifier.
    /// </summary>
    public partial class UpdateResourceEventConfigurationRequest : AmazonIoTWirelessRequest
    {
        private DeviceRegistrationStateEventConfiguration _deviceRegistrationState;
        private string _identifier;
        private IdentifierType _identifierType;
        private EventNotificationPartnerType _partnerType;
        private ProximityEventConfiguration _proximity;

        /// <summary>
        /// Gets and sets the property DeviceRegistrationState. 
        /// <para>
        /// Event configuration for the device registration state event
        /// </para>
        /// </summary>
        public DeviceRegistrationStateEventConfiguration DeviceRegistrationState
        {
            get { return this._deviceRegistrationState; }
            set { this._deviceRegistrationState = value; }
        }

        // Check to see if DeviceRegistrationState property is set
        internal bool IsSetDeviceRegistrationState()
        {
            return this._deviceRegistrationState != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Resource identifier to opt in for event messaging.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property IdentifierType. 
        /// <para>
        /// Identifier type of the particular resource identifier for event configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IdentifierType IdentifierType
        {
            get { return this._identifierType; }
            set { this._identifierType = value; }
        }

        // Check to see if IdentifierType property is set
        internal bool IsSetIdentifierType()
        {
            return this._identifierType != null;
        }

        /// <summary>
        /// Gets and sets the property PartnerType. 
        /// <para>
        /// Partner type of the resource if the identifier type is PartnerAccountId
        /// </para>
        /// </summary>
        public EventNotificationPartnerType PartnerType
        {
            get { return this._partnerType; }
            set { this._partnerType = value; }
        }

        // Check to see if PartnerType property is set
        internal bool IsSetPartnerType()
        {
            return this._partnerType != null;
        }

        /// <summary>
        /// Gets and sets the property Proximity. 
        /// <para>
        /// Event configuration for the Proximity event
        /// </para>
        /// </summary>
        public ProximityEventConfiguration Proximity
        {
            get { return this._proximity; }
            set { this._proximity = value; }
        }

        // Check to see if Proximity property is set
        internal bool IsSetProximity()
        {
            return this._proximity != null;
        }

    }
}