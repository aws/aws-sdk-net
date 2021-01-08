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
    /// Container for the parameters to the CreateConnectorProfile operation.
    /// Creates a new connector profile associated with your AWS account. There is a soft
    /// quota of 100 connector profiles per AWS account. If you need more connector profiles
    /// than this quota allows, you can submit a request to the Amazon AppFlow team through
    /// the Amazon AppFlow support channel.
    /// </summary>
    public partial class CreateConnectorProfileRequest : AmazonAppflowRequest
    {
        private ConnectionMode _connectionMode;
        private ConnectorProfileConfig _connectorProfileConfig;
        private string _connectorProfileName;
        private ConnectorType _connectorType;
        private string _kmsArn;

        /// <summary>
        /// Gets and sets the property ConnectionMode. 
        /// <para>
        ///  Indicates the connection mode and specifies whether it is public or private. Private
        /// flows use AWS PrivateLink to route data over AWS infrastructure without exposing it
        /// to the public internet. 
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
        ///  The name of the connector profile. The name is unique for each <code>ConnectorProfile</code>
        /// in your AWS account. 
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