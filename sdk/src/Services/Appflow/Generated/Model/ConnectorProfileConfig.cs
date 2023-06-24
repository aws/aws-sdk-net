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
    /// Defines the connector-specific configuration and credentials for the connector profile.
    /// </summary>
    public partial class ConnectorProfileConfig
    {
        private ConnectorProfileCredentials _connectorProfileCredentials;
        private ConnectorProfileProperties _connectorProfileProperties;

        /// <summary>
        /// Gets and sets the property ConnectorProfileCredentials. 
        /// <para>
        ///  The connector-specific credentials required by each connector. 
        /// </para>
        /// </summary>
        public ConnectorProfileCredentials ConnectorProfileCredentials
        {
            get { return this._connectorProfileCredentials; }
            set { this._connectorProfileCredentials = value; }
        }

        // Check to see if ConnectorProfileCredentials property is set
        internal bool IsSetConnectorProfileCredentials()
        {
            return this._connectorProfileCredentials != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorProfileProperties. 
        /// <para>
        ///  The connector-specific properties of the profile configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectorProfileProperties ConnectorProfileProperties
        {
            get { return this._connectorProfileProperties; }
            set { this._connectorProfileProperties = value; }
        }

        // Check to see if ConnectorProfileProperties property is set
        internal bool IsSetConnectorProfileProperties()
        {
            return this._connectorProfileProperties != null;
        }

    }
}