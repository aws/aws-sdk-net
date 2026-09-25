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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Container for the parameters to the SendManagedThingCommand operation. Send the command
    /// to the device represented by the managed thing.
    /// </summary>
    public partial class SendManagedThingCommandRequest : AmazonIoTManagedIntegrationsRequest
    {
        /// <summary>
        /// Gets and sets the property AccountAssociationId. 
        /// <para>
        /// The identifier of the account association to use when sending a command to a managed
        /// thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AccountAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AccountAssociationId property is set.
        /// </summary>
        internal bool IsSetAccountAssociationId() => this.AccountAssociationId != null;

        /// <summary>
        /// Gets and sets the property ConnectorAssociationId. 
        /// <para>
        /// The ID tracking the current discovery process for one connector association.
        /// </para>
        /// </summary>
        [Obsolete("ConnectorAssociationId has been deprecated")]
        [AWSProperty(Min = 1, Max = 64)]
        public string ConnectorAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorAssociationId property is set.
        /// </summary>
        internal bool IsSetConnectorAssociationId() => this.ConnectorAssociationId != null;

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The device endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public List<CommandEndpoint> Endpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<CommandEndpoint>() : null;

        /// <summary>
        /// Checks to see if the Endpoints property is set.
        /// </summary>
        internal bool IsSetEndpoints() => this.Endpoints != null && (this.Endpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ManagedThingId. 
        /// <para>
        /// The id of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ManagedThingId { get; set; }

        /// <summary>
        /// Checks to see if the ManagedThingId property is set.
        /// </summary>
        internal bool IsSetManagedThingId() => this.ManagedThingId != null;
    }
}
