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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
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
        private Dictionary<string, string> _clientAssociationMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _clientId;
        private string _eventBridgeRuleName;
        private string _eventIntegrationAssociationArn;
        private string _eventIntegrationAssociationId;
        private string _eventIntegrationName;

        /// <summary>
        /// Gets and sets the property ClientAssociationMetadata. 
        /// <para>
        /// The metadata associated with the client.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ClientAssociationMetadata
        {
            get { return this._clientAssociationMetadata; }
            set { this._clientAssociationMetadata = value; }
        }

        // Check to see if ClientAssociationMetadata property is set
        internal bool IsSetClientAssociationMetadata()
        {
            return this._clientAssociationMetadata != null && (this._clientAssociationMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The identifier for the client that is associated with the event integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property EventBridgeRuleName. 
        /// <para>
        /// The name of the EventBridge rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string EventBridgeRuleName
        {
            get { return this._eventBridgeRuleName; }
            set { this._eventBridgeRuleName = value; }
        }

        // Check to see if EventBridgeRuleName property is set
        internal bool IsSetEventBridgeRuleName()
        {
            return this._eventBridgeRuleName != null;
        }

        /// <summary>
        /// Gets and sets the property EventIntegrationAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the event integration association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string EventIntegrationAssociationArn
        {
            get { return this._eventIntegrationAssociationArn; }
            set { this._eventIntegrationAssociationArn = value; }
        }

        // Check to see if EventIntegrationAssociationArn property is set
        internal bool IsSetEventIntegrationAssociationArn()
        {
            return this._eventIntegrationAssociationArn != null;
        }

        /// <summary>
        /// Gets and sets the property EventIntegrationAssociationId. 
        /// <para>
        /// The identifier for the event integration association.
        /// </para>
        /// </summary>
        public string EventIntegrationAssociationId
        {
            get { return this._eventIntegrationAssociationId; }
            set { this._eventIntegrationAssociationId = value; }
        }

        // Check to see if EventIntegrationAssociationId property is set
        internal bool IsSetEventIntegrationAssociationId()
        {
            return this._eventIntegrationAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property EventIntegrationName. 
        /// <para>
        /// The name of the event integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string EventIntegrationName
        {
            get { return this._eventIntegrationName; }
            set { this._eventIntegrationName = value; }
        }

        // Check to see if EventIntegrationName property is set
        internal bool IsSetEventIntegrationName()
        {
            return this._eventIntegrationName != null;
        }

    }
}