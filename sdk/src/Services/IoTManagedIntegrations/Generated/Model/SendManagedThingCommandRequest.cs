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
    /// Container for the parameters to the SendManagedThingCommand operation.
    /// Send the command to the device represented by the managed thing.
    /// </summary>
    public partial class SendManagedThingCommandRequest : AmazonIoTManagedIntegrationsRequest
    {
        private string _accountAssociationId;
        private string _connectorAssociationId;
        private List<CommandEndpoint> _endpoints = AWSConfigs.InitializeCollections ? new List<CommandEndpoint>() : null;
        private string _managedThingId;

        /// <summary>
        /// Gets and sets the property AccountAssociationId. 
        /// <para>
        /// The identifier of the account association to use when sending a command to a managed
        /// thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ConnectorAssociationId. 
        /// <para>
        /// The ID tracking the current discovery process for one connector association.
        /// </para>
        /// </summary>
        [Obsolete("ConnectorAssociationId has been deprecated")]
        [AWSProperty(Min=1, Max=64)]
        public string ConnectorAssociationId
        {
            get { return this._connectorAssociationId; }
            set { this._connectorAssociationId = value; }
        }

        // Check to see if ConnectorAssociationId property is set
        internal bool IsSetConnectorAssociationId()
        {
            return this._connectorAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The device endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<CommandEndpoint> Endpoints
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }

        // Check to see if Endpoints property is set
        internal bool IsSetEndpoints()
        {
            return this._endpoints != null && (this._endpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ManagedThingId. 
        /// <para>
        /// The id of the device.
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