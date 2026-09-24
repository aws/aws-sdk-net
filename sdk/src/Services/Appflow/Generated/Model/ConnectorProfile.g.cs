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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ConnectionMode. 
        /// <para>
        ///  Indicates the connection mode and if it is public or private. 
        /// </para>
        /// </summary>
        public ConnectionMode ConnectionMode { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionMode property is set.
        /// </summary>
        internal bool IsSetConnectionMode() => this.ConnectionMode != null;

        /// <summary>
        /// Gets and sets the property ConnectorLabel. 
        /// <para>
        /// The label for the connector profile being created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ConnectorLabel { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorLabel property is set.
        /// </summary>
        internal bool IsSetConnectorLabel() => this.ConnectorLabel != null;

        /// <summary>
        /// Gets and sets the property ConnectorProfileArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the connector profile. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string ConnectorProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorProfileArn property is set.
        /// </summary>
        internal bool IsSetConnectorProfileArn() => this.ConnectorProfileArn != null;

        /// <summary>
        /// Gets and sets the property ConnectorProfileName. 
        /// <para>
        ///  The name of the connector profile. The name is unique for each <c>ConnectorProfile</c>
        /// in the Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ConnectorProfileName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorProfileName property is set.
        /// </summary>
        internal bool IsSetConnectorProfileName() => this.ConnectorProfileName != null;

        /// <summary>
        /// Gets and sets the property ConnectorProfileProperties. 
        /// <para>
        ///  The connector-specific properties of the profile configuration. 
        /// </para>
        /// </summary>
        public ConnectorProfileProperties ConnectorProfileProperties { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorProfileProperties property is set.
        /// </summary>
        internal bool IsSetConnectorProfileProperties() => this.ConnectorProfileProperties != null;

        /// <summary>
        /// Gets and sets the property ConnectorType. 
        /// <para>
        ///  The type of connector, such as Salesforce, Amplitude, and so on. 
        /// </para>
        /// </summary>
        public ConnectorType ConnectorType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorType property is set.
        /// </summary>
        internal bool IsSetConnectorType() => this.ConnectorType != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  Specifies when the connector profile was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CredentialsArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the connector profile credentials. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string CredentialsArn { get; set; }

        /// <summary>
        /// Checks to see if the CredentialsArn property is set.
        /// </summary>
        internal bool IsSetCredentialsArn() => this.CredentialsArn != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        ///  Specifies when the connector profile was last updated. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property PrivateConnectionProvisioningState. 
        /// <para>
        ///  Specifies the private connection provisioning state. 
        /// </para>
        /// </summary>
        public PrivateConnectionProvisioningState PrivateConnectionProvisioningState { get; set; }

        /// <summary>
        /// Checks to see if the PrivateConnectionProvisioningState property is set.
        /// </summary>
        internal bool IsSetPrivateConnectionProvisioningState() => this.PrivateConnectionProvisioningState != null;
    }
}
