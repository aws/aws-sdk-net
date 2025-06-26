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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterAccountAssociation operation.
    /// Registers an account association with a managed thing, establishing a connection between
    /// a device and a third-party account.
    /// </summary>
    public partial class RegisterAccountAssociationRequest : AmazonIoTManagedIntegrationsRequest
    {
        private string _accountAssociationId;
        private string _deviceDiscoveryId;
        private string _managedThingId;

        /// <summary>
        /// Gets and sets the property AccountAssociationId. 
        /// <para>
        /// The identifier of the account association to register with the managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string AccountAssociationId
        {
            get { return this._accountAssociationId; }
            set { this._accountAssociationId = value; }
        }

        // Check to see if AccountAssociationId property is set
        internal bool IsSetAccountAssociationId()
        {
            return this._accountAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceDiscoveryId. 
        /// <para>
        /// The identifier of the device discovery job associated with this registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string DeviceDiscoveryId
        {
            get { return this._deviceDiscoveryId; }
            set { this._deviceDiscoveryId = value; }
        }

        // Check to see if DeviceDiscoveryId property is set
        internal bool IsSetDeviceDiscoveryId()
        {
            return this._deviceDiscoveryId != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedThingId. 
        /// <para>
        /// The identifier of the managed thing to register with the account association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ManagedThingId
        {
            get { return this._managedThingId; }
            set { this._managedThingId = value; }
        }

        // Check to see if ManagedThingId property is set
        internal bool IsSetManagedThingId()
        {
            return this._managedThingId != null;
        }

    }
}