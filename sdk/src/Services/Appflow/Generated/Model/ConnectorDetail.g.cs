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
    /// Information about the registered connector.
    /// </summary>
    public partial class ConnectorDetail
    {
        /// <summary>
        /// Gets and sets the property ApplicationType. 
        /// <para>
        /// The application type of the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationType property is set.
        /// </summary>
        internal bool IsSetApplicationType() => this.ApplicationType != null;

        /// <summary>
        /// Gets and sets the property ConnectorDescription. 
        /// <para>
        /// A description about the registered connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string ConnectorDescription { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorDescription property is set.
        /// </summary>
        internal bool IsSetConnectorDescription() => this.ConnectorDescription != null;

        /// <summary>
        /// Gets and sets the property ConnectorLabel. 
        /// <para>
        /// A label used for the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ConnectorLabel { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorLabel property is set.
        /// </summary>
        internal bool IsSetConnectorLabel() => this.ConnectorLabel != null;

        /// <summary>
        /// Gets and sets the property ConnectorModes. 
        /// <para>
        /// The connection mode that the connector supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ConnectorModes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConnectorModes property is set.
        /// </summary>
        internal bool IsSetConnectorModes() => this.ConnectorModes != null && (this.ConnectorModes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectorName. 
        /// <para>
        /// The name of the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ConnectorName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorName property is set.
        /// </summary>
        internal bool IsSetConnectorName() => this.ConnectorName != null;

        /// <summary>
        /// Gets and sets the property ConnectorOwner. 
        /// <para>
        /// The owner of the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ConnectorOwner { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorOwner property is set.
        /// </summary>
        internal bool IsSetConnectorOwner() => this.ConnectorOwner != null;

        /// <summary>
        /// Gets and sets the property ConnectorProvisioningType. 
        /// <para>
        /// The provisioning type that the connector uses.
        /// </para>
        /// </summary>
        public ConnectorProvisioningType ConnectorProvisioningType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorProvisioningType property is set.
        /// </summary>
        internal bool IsSetConnectorProvisioningType() => this.ConnectorProvisioningType != null;

        /// <summary>
        /// Gets and sets the property ConnectorType. 
        /// <para>
        /// The connector type.
        /// </para>
        /// </summary>
        public ConnectorType ConnectorType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorType property is set.
        /// </summary>
        internal bool IsSetConnectorType() => this.ConnectorType != null;

        /// <summary>
        /// Gets and sets the property ConnectorVersion. 
        /// <para>
        /// The connector version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ConnectorVersion { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorVersion property is set.
        /// </summary>
        internal bool IsSetConnectorVersion() => this.ConnectorVersion != null;

        /// <summary>
        /// Gets and sets the property RegisteredAt. 
        /// <para>
        /// The time at which the connector was registered.
        /// </para>
        /// </summary>
        public DateTime? RegisteredAt { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredAt property is set.
        /// </summary>
        internal bool IsSetRegisteredAt() => this.RegisteredAt.HasValue;

        /// <summary>
        /// Gets and sets the property RegisteredBy. 
        /// <para>
        /// The user who registered the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string RegisteredBy { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredBy property is set.
        /// </summary>
        internal bool IsSetRegisteredBy() => this.RegisteredBy != null;

        /// <summary>
        /// Gets and sets the property SupportedDataTransferTypes. 
        /// <para>
        /// The data transfer types that the connector supports.
        /// </para>
        ///  <dl> <dt>RECORD</dt> <dd> 
        /// <para>
        /// Structured records.
        /// </para>
        ///  </dd> <dt>FILE</dt> <dd> 
        /// <para>
        /// Files or binary data.
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedDataTransferTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedDataTransferTypes property is set.
        /// </summary>
        internal bool IsSetSupportedDataTransferTypes() => this.SupportedDataTransferTypes != null && (this.SupportedDataTransferTypes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
