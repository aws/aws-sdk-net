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
    /// Container for the parameters to the CreateConnectorProfile operation.
    /// Creates a new connector profile associated with your Amazon Web Services account.
    /// There is a soft quota of 100 connector profiles per Amazon Web Services account. If
    /// you need more connector profiles than this quota allows, you can submit a request
    /// to the Amazon AppFlow team through the Amazon AppFlow support channel. In each connector
    /// profile that you create, you can provide the credentials and properties for only one
    /// connector.
    /// </summary>
    public partial class CreateConnectorProfileRequest : AmazonAppflowRequest
    {
        private string _clientToken;
        private ConnectionMode _connectionMode;
        private string _connectorLabel;
        private ConnectorProfileConfig _connectorProfileConfig;
        private string _connectorProfileName;
        private ConnectorType _connectorType;
        private string _kmsArn;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The <c>clientToken</c> parameter is an idempotency token. It ensures that your <c>CreateConnectorProfile</c>
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
        /// new call to <c>CreateConnectorProfile</c>. The token is active for 8 hours.
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
        ///  Indicates the connection mode and specifies whether it is public or private. Private
        /// flows use Amazon Web Services PrivateLink to route data over Amazon Web Services infrastructure
        /// without exposing it to the public internet. 
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
        /// Gets and sets the property ConnectorLabel. 
        /// <para>
        /// The label of the connector. The label is unique for each <c>ConnectorRegistration</c>
        /// in your Amazon Web Services account. Only needed if calling for CUSTOMCONNECTOR connector
        /// type/.
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
        /// Gets and sets the property ConnectorProfileConfig. 
        /// <para>
        ///  Defines the connector-specific configuration and credentials. 
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
        ///  The name of the connector profile. The name is unique for each <c>ConnectorProfile</c>
        /// in your Amazon Web Services account. 
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

        /// <summary>
        /// Gets and sets the property ConnectorType. 
        /// <para>
        ///  The type of connector, such as Salesforce, Amplitude, and so on. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectorType ConnectorType
        {
            get { return this._connectorType; }
            set { this._connectorType = value; }
        }

        // Check to see if ConnectorType property is set
        internal bool IsSetConnectorType()
        {
            return this._connectorType != null;
        }

        /// <summary>
        /// Gets and sets the property KmsArn. 
        /// <para>
        ///  The ARN (Amazon Resource Name) of the Key Management Service (KMS) key you provide
        /// for encryption. This is required if you do not want to use the Amazon AppFlow-managed
        /// KMS key. If you don't provide anything here, Amazon AppFlow uses the Amazon AppFlow-managed
        /// KMS key. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KmsArn
        {
            get { return this._kmsArn; }
            set { this._kmsArn = value; }
        }

        // Check to see if KmsArn property is set
        internal bool IsSetKmsArn()
        {
            return this._kmsArn != null;
        }

    }
}