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
    /// This is the response object from the GetEventConfigurationByResourceTypes operation.
    /// </summary>
    public partial class GetEventConfigurationByResourceTypesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConnectionStatus. 
        /// <para>
        /// Resource type event configuration for the connection status event.
        /// </para>
        /// </summary>
        public ConnectionStatusResourceTypeEventConfiguration ConnectionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionStatus property is set.
        /// </summary>
        internal bool IsSetConnectionStatus() => this.ConnectionStatus != null;

        /// <summary>
        /// Gets and sets the property DeviceRegistrationState. 
        /// <para>
        /// Resource type event configuration for the device registration state event.
        /// </para>
        /// </summary>
        public DeviceRegistrationStateResourceTypeEventConfiguration DeviceRegistrationState { get; set; }

        /// <summary>
        /// Checks to see if the DeviceRegistrationState property is set.
        /// </summary>
        internal bool IsSetDeviceRegistrationState() => this.DeviceRegistrationState != null;

        /// <summary>
        /// Gets and sets the property Join. 
        /// <para>
        /// Resource type event configuration for the join event.
        /// </para>
        /// </summary>
        public JoinResourceTypeEventConfiguration Join { get; set; }

        /// <summary>
        /// Checks to see if the Join property is set.
        /// </summary>
        internal bool IsSetJoin() => this.Join != null;

        /// <summary>
        /// Gets and sets the property MessageDeliveryStatus. 
        /// <para>
        /// Resource type event configuration object for the message delivery status event.
        /// </para>
        /// </summary>
        public MessageDeliveryStatusResourceTypeEventConfiguration MessageDeliveryStatus { get; set; }

        /// <summary>
        /// Checks to see if the MessageDeliveryStatus property is set.
        /// </summary>
        internal bool IsSetMessageDeliveryStatus() => this.MessageDeliveryStatus != null;

        /// <summary>
        /// Gets and sets the property Proximity. 
        /// <para>
        /// Resource type event configuration for the proximity event.
        /// </para>
        /// </summary>
        public ProximityResourceTypeEventConfiguration Proximity { get; set; }

        /// <summary>
        /// Checks to see if the Proximity property is set.
        /// </summary>
        internal bool IsSetProximity() => this.Proximity != null;
    }
}
