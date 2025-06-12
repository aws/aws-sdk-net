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
    /// A structure that is used to specify testing a connection to a service.
    /// </summary>
    public partial class TestConnectionInput
    {
        private AuthenticationConfigurationInput _authenticationConfiguration;
        private Dictionary<string, string> _connectionProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ConnectionType _connectionType;

        /// <summary>
        /// Gets and sets the property AuthenticationConfiguration. 
        /// <para>
        /// A structure containing the authentication configuration in the TestConnection request.
        /// Required for a connection to Salesforce using OAuth authentication.
        /// </para>
        /// </summary>
        public AuthenticationConfigurationInput AuthenticationConfiguration
        {
            get { return this._authenticationConfiguration; }
            set { this._authenticationConfiguration = value; }
        }

        // Check to see if AuthenticationConfiguration property is set
        internal bool IsSetAuthenticationConfiguration()
        {
            return this._authenticationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionProperties. 
        /// <para>
        /// The key-value pairs that define parameters for the connection.
        /// </para>
        ///  
        /// <para>
        /// JDBC connections use the following connection properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required: All of (<c>HOST</c>, <c>PORT</c>, <c>JDBC_ENGINE</c>) or <c>JDBC_CONNECTION_URL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Required: All of (<c>USERNAME</c>, <c>PASSWORD</c>) or <c>SECRET_ID</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optional: <c>JDBC_ENFORCE_SSL</c>, <c>CUSTOM_JDBC_CERT</c>, <c>CUSTOM_JDBC_CERT_STRING</c>,
        /// <c>SKIP_CUSTOM_JDBC_CERT_VALIDATION</c>. These parameters are used to configure SSL
        /// with JDBC.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// SALESFORCE connections require the <c>AuthenticationConfiguration</c> member to be
        /// configured.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public Dictionary<string, string> ConnectionProperties
        {
            get { return this._connectionProperties; }
            set { this._connectionProperties = value; }
        }

        // Check to see if ConnectionProperties property is set
        internal bool IsSetConnectionProperties()
        {
            return this._connectionProperties != null && (this._connectionProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The type of connection to test. This operation is only available for the <c>JDBC</c>
        /// or <c>SALESFORCE</c> connection types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionType ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        // Check to see if ConnectionType property is set
        internal bool IsSetConnectionType()
        {
            return this._connectionType != null;
        }

    }
}