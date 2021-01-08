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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConnectorProfile operation.
    /// Updates a given connector profile associated with your account.
    /// </summary>
    public partial class UpdateConnectorProfileRequest : AmazonAppflowRequest
    {
        private ConnectionMode _connectionMode;
        private ConnectorProfileConfig _connectorProfileConfig;
        private string _connectorProfileName;

        /// <summary>
        /// Gets and sets the property ConnectionMode. 
        /// <para>
        ///  Indicates the connection mode and if it is public or private. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionMode ConnectionMode
        {
            get { return this._connectionMode; }
            set { this._connectionMode = value; }
        }

        // Check to see if ConnectionMode property is set
        internal bool IsSetConnectionMode()
        {
            return this._connectionMode != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorProfileConfig. 
        /// <para>
        ///  Defines the connector-specific profile configuration and credentials. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectorProfileConfig ConnectorProfileConfig
        {
            get { return this._connectorProfileConfig; }
            set { this._connectorProfileConfig = value; }
        }

        // Check to see if ConnectorProfileConfig property is set
        internal bool IsSetConnectorProfileConfig()
        {
            return this._connectorProfileConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorProfileName. 
        /// <para>
        ///  The name of the connector profile and is unique for each <code>ConnectorProfile</code>
        /// in the AWS Account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ConnectorProfileName
        {
            get { return this._connectorProfileName; }
            set { this._connectorProfileName = value; }
        }

        // Check to see if ConnectorProfileName property is set
        internal bool IsSetConnectorProfileName()
        {
            return this._connectorProfileName != null;
        }

    }
}