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
    /// Container for the parameters to the RegisterConnector operation.
    /// Registers a new connector with your Amazon Web Services account. Before you can register
    /// the connector, you must deploy lambda in your account.
    /// </summary>
    public partial class RegisterConnectorRequest : AmazonAppflowRequest
    {
        private string _connectorLabel;
        private ConnectorProvisioningConfig _connectorProvisioningConfig;
        private ConnectorProvisioningType _connectorProvisioningType;
        private string _description;

        /// <summary>
        /// Gets and sets the property ConnectorLabel. 
        /// <para>
        ///  The name of the connector. The name is unique for each <code>ConnectorRegistration</code>
        /// in your Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ConnectorLabel
        {
            get { return this._connectorLabel; }
            set { this._connectorLabel = value; }
        }

        // Check to see if ConnectorLabel property is set
        internal bool IsSetConnectorLabel()
        {
            return this._connectorLabel != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorProvisioningConfig. 
        /// <para>
        /// The provisioning type of the connector. Currently the only supported value is LAMBDA.
        /// </para>
        /// </summary>
        public ConnectorProvisioningConfig ConnectorProvisioningConfig
        {
            get { return this._connectorProvisioningConfig; }
            set { this._connectorProvisioningConfig = value; }
        }

        // Check to see if ConnectorProvisioningConfig property is set
        internal bool IsSetConnectorProvisioningConfig()
        {
            return this._connectorProvisioningConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorProvisioningType. 
        /// <para>
        /// The provisioning type of the connector. Currently the only supported value is LAMBDA.
        /// 
        /// </para>
        /// </summary>
        public ConnectorProvisioningType ConnectorProvisioningType
        {
            get { return this._connectorProvisioningType; }
            set { this._connectorProvisioningType = value; }
        }

        // Check to see if ConnectorProvisioningType property is set
        internal bool IsSetConnectorProvisioningType()
        {
            return this._connectorProvisioningType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description about the connector that's being registered.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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

    }
}