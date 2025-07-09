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
    /// This is the response object from the GetConnectorDestination operation.
    /// </summary>
    public partial class GetConnectorDestinationResponse : AmazonWebServiceResponse
    {
        private AuthConfig _authConfig;
        private AuthType _authType;
        private string _cloudConnectorId;
        private string _description;
        private string _id;
        private string _name;
        private string _oAuthCompleteRedirectUrl;
        private SecretsManager _secretsManager;

        /// <summary>
        /// Gets and sets the property AuthConfig. 
        /// <para>
        /// The authentication configuration details for the connector destination, including
        /// OAuth settings and other authentication parameters.
        /// </para>
        /// </summary>
        public AuthConfig AuthConfig
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
        /// The authentication type used for the connector destination, which determines how credentials
        /// and access are managed.
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
        /// Gets and sets the property CloudConnectorId. 
        /// <para>
        /// The identifier of the C2C connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CloudConnectorId
        {
            get { return this._cloudConnectorId; }
            set { this._cloudConnectorId = value; }
        }

        // Check to see if CloudConnectorId property is set
        internal bool IsSetCloudConnectorId()
        {
            return this._cloudConnectorId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the connector destination.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the connector destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the connector destination.
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
        /// Gets and sets the property OAuthCompleteRedirectUrl. 
        /// <para>
        /// The URL where users are redirected after completing the OAuth authorization process
        /// for the connector destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string OAuthCompleteRedirectUrl
        {
            get { return this._oAuthCompleteRedirectUrl; }
            set { this._oAuthCompleteRedirectUrl = value; }
        }

        // Check to see if OAuthCompleteRedirectUrl property is set
        internal bool IsSetOAuthCompleteRedirectUrl()
        {
            return this._oAuthCompleteRedirectUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManager. 
        /// <para>
        /// The AWS Secrets Manager configuration used to securely store and manage sensitive
        /// information for the connector destination.
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