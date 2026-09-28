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

namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// The event integration association.
    /// </summary>
    public partial class EventIntegrationAssociation
    {
        /// <summary>
        /// Gets and sets the property ClientAssociationMetadata. 
        /// <para>
        /// The metadata associated with the client.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ClientAssociationMetadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ClientAssociationMetadata property is set.
        /// </summary>
        internal bool IsSetClientAssociationMetadata() => this.ClientAssociationMetadata != null && (this.ClientAssociationMetadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The identifier for the client that is associated with the event integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property EventBridgeRuleName. 
        /// <para>
        /// The name of the EventBridge rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string EventBridgeRuleName { get; set; }

        /// <summary>
        /// Checks to see if the EventBridgeRuleName property is set.
        /// </summary>
        internal bool IsSetEventBridgeRuleName() => this.EventBridgeRuleName != null;

        /// <summary>
        /// Gets and sets the property EventIntegrationAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the event integration association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string EventIntegrationAssociationArn { get; set; }

        /// <summary>
        /// Checks to see if the EventIntegrationAssociationArn property is set.
        /// </summary>
        internal bool IsSetEventIntegrationAssociationArn() => this.EventIntegrationAssociationArn != null;

        /// <summary>
        /// Gets and sets the property EventIntegrationAssociationId. 
        /// <para>
        /// The identifier for the event integration association.
        /// </para>
        /// </summary>
        public string EventIntegrationAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the EventIntegrationAssociationId property is set.
        /// </summary>
        internal bool IsSetEventIntegrationAssociationId() => this.EventIntegrationAssociationId != null;

        /// <summary>
        /// Gets and sets the property EventIntegrationName. 
        /// <para>
        /// The name of the event integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string EventIntegrationName { get; set; }

        /// <summary>
        /// Checks to see if the EventIntegrationName property is set.
        /// </summary>
        internal bool IsSetEventIntegrationName() => this.EventIntegrationName != null;
    }
}
