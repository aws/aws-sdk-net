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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterConnector operation.
    /// Registers a new custom connector with your Amazon Web Services account. Before you
    /// can register the connector, you must deploy the associated AWS lambda function in
    /// your account.
    /// </summary>
    public partial class RegisterConnectorRequest : AmazonAppflowRequest
    {
        private string _clientToken;
        private string _connectorLabel;
        private ConnectorProvisioningConfig _connectorProvisioningConfig;
        private ConnectorProvisioningType _connectorProvisioningType;
        private string _description;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The <c>clientToken</c> parameter is an idempotency token. It ensures that your <c>RegisterConnector</c>
        /// request completes only once. You choose the value to pass. For example, if you don't
        /// receive a response from your request, you can safely retry the request with the same
        /// <c>clientToken</c> parameter value.
        /// </para>
        ///  
        /// <para>
        /// If you omit a <c>clientToken</c> value, the Amazon Web Services SDK that you are using
        /// inserts a value for you. This way, the SDK can safely retry requests multiple times
        /// after a network error. You must provide your own value for other use cases.
        /// </para>
        ///  
        /// <para>
        /// If you specify input parameters that differ from your first request, an error occurs.
        /// If you use a different value for <c>clientToken</c>, Amazon AppFlow considers it a
        /// new call to <c>RegisterConnector</c>. The token is active for 8 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorLabel. 
        /// <para>
        ///  The name of the connector. The name is unique for each <c>ConnectorRegistration</c>
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