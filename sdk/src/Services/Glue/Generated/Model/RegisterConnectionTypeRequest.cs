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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterConnectionType operation.
    /// Registers a custom connection type in Glue based on the configuration provided. This
    /// operation enables customers to configure custom connectors for any data source with
    /// REST-based APIs, eliminating the need for building custom Lambda connectors.
    /// 
    ///  
    /// <para>
    /// The registered connection type stores details about how requests and responses are
    /// interpreted by REST sources, including connection properties, authentication configuration,
    /// and REST configuration with entity definitions. Once registered, customers can create
    /// connections using this connection type and work with them the same way as natively
    /// supported Glue connectors.
    /// </para>
    ///  
    /// <para>
    /// Supports multiple authentication types including Basic, OAuth2 (Client Credentials,
    /// JWT Bearer, Authorization Code), and Custom Auth configurations.
    /// </para>
    /// </summary>
    public partial class RegisterConnectionTypeRequest : AmazonGlueRequest
    {
        private ConnectionPropertiesConfiguration _connectionProperties;
        private string _connectionType;
        private ConnectorAuthenticationConfiguration _connectorAuthenticationConfiguration;
        private string _description;
        private IntegrationType _integrationType;
        private RestConfiguration _restConfiguration;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ConnectionProperties. 
        /// <para>
        /// Defines the base URL and additional request parameters needed during connection creation
        /// for this connection type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionPropertiesConfiguration ConnectionProperties
        {
            get { return this._connectionProperties; }
            set { this._connectionProperties = value; }
        }

        // Check to see if ConnectionProperties property is set
        internal bool IsSetConnectionProperties()
        {
            return this._connectionProperties != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The name of the connection type. Must be between 1 and 255 characters and must be
        /// prefixed with "REST-" to indicate it is a REST-based connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        // Check to see if ConnectionType property is set
        internal bool IsSetConnectionType()
        {
            return this._connectionType != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorAuthenticationConfiguration. 
        /// <para>
        /// Defines the supported authentication types and required properties for this connection
        /// type, including Basic, OAuth2, and Custom authentication methods.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectorAuthenticationConfiguration ConnectorAuthenticationConfiguration
        {
            get { return this._connectorAuthenticationConfiguration; }
            set { this._connectorAuthenticationConfiguration = value; }
        }

        // Check to see if ConnectorAuthenticationConfiguration property is set
        internal bool IsSetConnectorAuthenticationConfiguration()
        {
            return this._connectorAuthenticationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the connection type. Can be up to 2048 characters and provides details
        /// about the purpose and functionality of the connection type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property IntegrationType. 
        /// <para>
        /// The integration type for the connection. Currently only "REST" protocol is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IntegrationType IntegrationType
        {
            get { return this._integrationType; }
            set { this._integrationType = value; }
        }

        // Check to see if IntegrationType property is set
        internal bool IsSetIntegrationType()
        {
            return this._integrationType != null;
        }

        /// <summary>
        /// Gets and sets the property RestConfiguration. 
        /// <para>
        /// Defines the HTTP request and response configuration, validation endpoint, and entity
        /// configurations for REST API interactions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RestConfiguration RestConfiguration
        {
            get { return this._restConfiguration; }
            set { this._restConfiguration = value; }
        }

        // Check to see if RestConfiguration property is set
        internal bool IsSetRestConfiguration()
        {
            return this._restConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags you assign to the connection type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}