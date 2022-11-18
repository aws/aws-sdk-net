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
    /// Container for the parameters to the UpdateConnectorRegistration operation.
    /// Updates a custom connector that you've previously registered. This operation updates
    /// the connector with one of the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The latest version of the AWS Lambda function that's assigned to the connector
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A new AWS Lambda function that you specify
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateConnectorRegistrationRequest : AmazonAppflowRequest
    {
        private string _connectorLabel;
        private ConnectorProvisioningConfig _connectorProvisioningConfig;
        private string _description;

        /// <summary>
        /// Gets and sets the property ConnectorLabel. 
        /// <para>
        /// The name of the connector. The name is unique for each connector registration in your
        /// AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description about the update that you're applying to the connector.
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