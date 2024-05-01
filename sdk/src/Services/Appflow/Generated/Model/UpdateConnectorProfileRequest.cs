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
    /// Container for the parameters to the UpdateConnectorProfile operation.
    /// Updates a given connector profile associated with your account.
    /// </summary>
    public partial class UpdateConnectorProfileRequest : AmazonAppflowRequest
    {
        private string _clientToken;
        private ConnectionMode _connectionMode;
        private ConnectorProfileConfig _connectorProfileConfig;
        private string _connectorProfileName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The <c>clientToken</c> parameter is an idempotency token. It ensures that your <c>UpdateConnectorProfile</c>
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
        /// new call to <c>UpdateConnectorProfile</c>. The token is active for 8 hours.
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
        ///  The name of the connector profile and is unique for each <c>ConnectorProfile</c>
        /// in the Amazon Web Services account. 
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