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
    /// Container for the parameters to the UpdateConnectorDestination operation.
    /// Updates the properties of an existing connector destination.
    /// </summary>
    public partial class UpdateConnectorDestinationRequest : AmazonIoTManagedIntegrationsRequest
    {
        private AuthConfigUpdate _authConfig;
        private AuthType _authType;
        private string _description;
        private string _identifier;
        private string _name;
        private SecretsManager _secretsManager;

        /// <summary>
        /// Gets and sets the property AuthConfig. 
        /// <para>
        /// The updated authentication configuration details for the connector destination.
        /// </para>
        /// </summary>
        public AuthConfigUpdate AuthConfig
        {
            get { return this._authConfig; }
            set { this._authConfig = value; }
        }

        // Check to see if AuthConfig property is set
        internal bool IsSetAuthConfig()
        {
            return this._authConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The new authentication type to use for the connector destination.
        /// </para>
        /// </summary>
        public AuthType AuthType
        {
            get { return this._authType; }
            set { this._authType = value; }
        }

        // Check to see if AuthType property is set
        internal bool IsSetAuthType()
        {
            return this._authType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description to assign to the connector destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique identifier of the connector destination to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The new display name to assign to the connector destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManager. 
        /// <para>
        /// The updated AWS Secrets Manager configuration for the connector destination.
        /// </para>
        /// </summary>
        public SecretsManager SecretsManager
        {
            get { return this._secretsManager; }
            set { this._secretsManager = value; }
        }

        // Check to see if SecretsManager property is set
        internal bool IsSetSecretsManager()
        {
            return this._secretsManager != null;
        }

    }
}