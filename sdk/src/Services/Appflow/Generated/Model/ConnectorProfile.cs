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
    /// Describes an instance of a connector. This includes the provided name, credentials
    /// ARN, connection-mode, and so on. To keep the API intuitive and extensible, the fields
    /// that are common to all types of connector profiles are explicitly specified at the
    /// top level. The rest of the connector-specific properties are available via the <c>connectorProfileProperties</c>
    /// field.
    /// </summary>
    public partial class ConnectorProfile
    {
        private ConnectionMode _connectionMode;
        private string _connectorLabel;
        private string _connectorProfileArn;
        private string _connectorProfileName;
        private ConnectorProfileProperties _connectorProfileProperties;
        private ConnectorType _connectorType;
        private DateTime? _createdAt;
        private string _credentialsArn;
        private DateTime? _lastUpdatedAt;
        private PrivateConnectionProvisioningState _privateConnectionProvisioningState;

        /// <summary>
        /// Gets and sets the property ConnectionMode. 
        /// <para>
        ///  Indicates the connection mode and if it is public or private. 
        /// </para>
        /// </summary>
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
        /// The label for the connector profile being created.
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
        /// Gets and sets the property ConnectorProfileArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the connector profile. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string ConnectorProfileArn
        {
            get { return this._connectorProfileArn; }
            set { this._connectorProfileArn = value; }
        }

        // Check to see if ConnectorProfileArn property is set
        internal bool IsSetConnectorProfileArn()
        {
            return this._connectorProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorProfileName. 
        /// <para>
        ///  The name of the connector profile. The name is unique for each <c>ConnectorProfile</c>
        /// in the Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property ConnectorProfileProperties. 
        /// <para>
        ///  The connector-specific properties of the profile configuration. 
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property ConnectorType. 
        /// <para>
        ///  The type of connector, such as Salesforce, Amplitude, and so on. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  Specifies when the connector profile was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CredentialsArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the connector profile credentials. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string CredentialsArn
        {
            get { return this._credentialsArn; }
            set { this._credentialsArn = value; }
        }

        // Check to see if CredentialsArn property is set
        internal bool IsSetCredentialsArn()
        {
            return this._credentialsArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        ///  Specifies when the connector profile was last updated. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrivateConnectionProvisioningState. 
        /// <para>
        ///  Specifies the private connection provisioning state. 
        /// </para>
        /// </summary>
        public PrivateConnectionProvisioningState PrivateConnectionProvisioningState
        {
            get { return this._privateConnectionProvisioningState; }
            set { this._privateConnectionProvisioningState = value; }
        }

        // Check to see if PrivateConnectionProvisioningState property is set
        internal bool IsSetPrivateConnectionProvisioningState()
        {
            return this._privateConnectionProvisioningState != null;
        }

    }
}